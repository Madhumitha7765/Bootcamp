# Proposed Context-Based Modules:

1. **Survey Module**
2. **KPI Module**
3. **Order Module**
4. **Customer Module**
5. **Maintenance Module**
6. **File Transfer Module**
7. **System Information Module**
8. **Error Logging Module**
9. **User Management Module**
10. **Utility Module**
11. **Connection Management Module**

### 1. Survey Module

Handles all operations related to surveys.

**Interface: `ISurveyRepository`**
```csharp
public interface ISurveyRepository
{
    void ReadSurveyPopUpText(CStringArray surveyPopUpText);
    void ReadSurveyQuestions(CStringArray surveyQuestions);
    void ReadSurveyRankings(CStringArray surveyRankings);
    CString GetNextSurveyInfo(int surveyId);
    void WriteSurveyResult(int surveyId, int userId, CString question, CString answer);
}
```

### 2. KPI Module

Handles all operations related to KPI monitoring.

**Interface: `IKPIRepository`**
```csharp
public interface IKPIRepository
{
    int GetKPIMonitorDetails(CStringArray kpiDetails);
    int GetKPIMonitorOrders(CStringArray kpiOrders);
    int GetKPIMonitorSummary(CStringArray kpiSummary);
    CString GetKPIMonitorUpdateInfo();
}
```

### 3. Orders Module

Handles all operations related to orders.

**Interface: `IOrdersRepository`**

```csharp
public interface IOrderRepository
{
    int MailDistInsert(int orderId, CString email, CStringArray details);
    int MailDistListGet(int orderId, CStringArray mailList);
    int InsertOrderData(int orderId, CString orderData);
    int InsertOrderItemTracking(int orderId, CString trackingInfo, CString item);
    int ModifyOrderItemTracking(int orderId, int trackingId, CString trackingInfo, CString item);
    int InsertOrderSpec(int orderId, int specId, CString specData);
    int InsertOrderSpecLD(int orderId, int specId, int ldId, int data);
    int GetNextOrderID();
    void ReadTableData(CString tableName, CStringArray tableData);
    void ReadSpecsData(CString specsData);
    void ReadBasicData(CString basicData);
    int GetOrderStatus(int orderId);
    void WriteOrderHistory(int orderId, int userId, int status, CString message, CString oldValue, CString newValue);
    void WriteOrderRemarks(int orderId, CString remarks, CString user, CString oldValue, CString newValue, CString additionalInfo);
    void UpdateOrderLensDetails(int orderId, int lensId, int data, CStringArray lensDetails, CStringArray additionalInfo);
    void UpdateOrderDetails(int orderId, int dataId, CString details);
    int UpdateOrderDetailsData(int orderId, int dataId, CString details, CString additionalInfo);
    void UpdateOrderDetails4Grb(int orderId, int dataId, int grbId, CString details, CString additionalInfo);
    void SetOrderStatus(int orderId, int status);
    void UpdateOrderFinishedTS(CString timeStamp, int orderId, int userId, int status);
}

```

### 4. Customer Module

Handles all operations related to customers.

**Interface: `ICustomerRepository`**
```csharp
public interface ICustomerRepository
{
    int ExportCustomerResultData(CString resultData, CString customerInfo, CString orderInfo, CString additionalInfo);
    int GetCustomerOrderInfo(int customerId, int orderId);
    int GetCustomerOrderInfoLatest(int customerId, int orderId);
    int GetCustomerOrderRemarks(int customerId, int orderId, int remarkId);
    int GetCustomerOrderLensDetailsStatus(CString lensDetails, int customerId, int orderId);
    int GetCustomerOrderLensDetailsInfo(int customerId, int orderId, CString lensDetails, CString additionalInfo);
    int GetCustomerOrderData(int customerId, int orderId, int dataId);
    int GetCustomerOrderDetails(int customerId, int orderId, int detailId);
    int GetCustomerOrderHistory(int customerId, int orderId, int historyId);
    int GetCustomerOrders(int customerId);
    int GetCustomerAddress(int customerId, CString address);
    int GetFilteredOrders(CString filter, CString additionalInfo);
    void ReadCustomerData(CString customerData);
}

```

### 5. Maintenance Module

Handles all operations related to system maintenance.

**Interface: `IMaintenanceRepository`**
```csharp
public interface IMaintenanceRepository
{
    void ReadMaintInfo(CStringArray maintInfo);
    void ReadUserAlert(CString userAlert, int alertId);
    void ReadGTCInfo();
}
```

### 6. File Transfer Module

Handles all operations related to file transfers.

**Interface: `IFileTransferRepository`**

```csharp
public interface IFileTransferRepository
{
    int GetFDTransferedFiles(int fileId);
    int UpdateFileTransferInfo(int fileId, CString transferInfo, CString additionalInfo);
    int InsertFileTransferInfo(int fileId, CString transferInfo, CString additionalInfo);
}

```

### 7. System Information Module
Handles all operations related to system information.

**Interface: `ISystemInformationRepository`**

```csharp
public interface ISystemInformationRepository
{
    int GetInfo4Software(CString softwareInfo, CString additionalInfo);
    int GetInfo4Server(CString serverInfo, CStringArray additionalInfo);
    int GetInfo4Client(CString clientInfo, CString additionalInfo, CStringArray clientDetails);
    void GetInfo4OrderSystemLog(int orderId, int systemLogId);
    void GetInfo4OrderHistory(int orderId, int historyId);
    void GetInfo4PDVersion(int pdVersionId);
    void GetInfo4ProtoID();
    void GetInfo4OrderReason();
    void GetInfo4Customer();
    void GetInfo4Patches();
    void GetInfo4Procedures();
    void GetGTCWorkload();
    void GetOpenOrders(CString orderStatus);
    void GetGTCTestPortfolio();
    void ConnectivityCheck();
}

```

### 8. Error Logging Module

Handles all error logging operations.

**Interface: `IErrorLoggingRepository`**

```csharp
public interface IErrorLoggingRepository
{
    void WriteErrorLog(int errorCode, CString errorMessage, CString additionalInfo, CString stackTrace, CString user);
    void WriteSystemLog(int logLevel, CString logMessage, CString additionalInfo, CString stackTrace, CString user);
}

```

### 9. User Management Module

Handles all user management operations.

**Interface: `IUserManagementRepository`**

```csharp
public interface IUserManagementRepository
{
    int UpdatePassword(CString username, CString oldPassword, CString newPassword);
    int GetUserData(CString username, CString userData);
}
```

### 10. Utility Module
Handles miscellaneous utility operations.

**Interface: `IUtilityRepository`**

```csharp
public interface IUtilityRepository
{
    CString CalcNewDateTime(CString dateTime, int interval, CString format);
    CString ConvertUnixTimeStamp(CString unixTimeStamp);
    CString GetServerDateTime(CString dateTimeFormat, CString serverInfo, CString additionalInfo);
    BOOL UpdateCounter(CString counterName, int incrementValue, int *currentValue, int *maxValue);
    void BackupOrderData(CString backupInfo, CString additionalInfo, int orderId, int userId, int status);
}
```

### 11.  Connection Management Module
Handles all database connection management.

**Interface: `IDbConnectionManager`**

```csharp
public interface IDbConnectionManager
{
    void Connect(CString connectionString);
    void Disconnect();
}
```



