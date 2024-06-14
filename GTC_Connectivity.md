# Database design approaches

## Modules overview

1. **Access logs**
   - **Details**:  Application, workstation, System Info, user details
   - **Insights**: There are several similar tables under same name
   - **Issue** :
      - ***Difficulty in querying data*** :  It becomes cumbersome to run queries across multiple tables.
      - ***Maintenance challenges*** : Schema changes must be applied to each table individually.
    - **Solution** : Can create one table, indexing technique can be used for columns with most retreival frequency
2. **System configurations and other versioning module**
   - **Tables**:  Systemlog, SetupInfo,maintenance, checkversions, application configs
3. **User data**
    - **Tables**:  userdata, userpermits, usermessagelog, customer, password, address
    - **Insights** :
      - ***priority table contains only levels and mapping to user type which can be formatted as enum object only.***        
4. **Orders module**
    - **Insights**:
        - ***Normalization*** : Ensure that OrderDetails is normalized to avoid redundancy.
        - ***Indexing*** : Create indexes on order_date, user_id for better query performance.
        - ***Usage of ENUMs***: Use ENUMs for order status to standardize the values.
5. **Test result matrix**

### Basic ER diagram
![image](https://github.com/Madhumitha7765/Bootcamp/assets/68181437/7cbba27d-4857-40c4-a83e-f0f97f340a43)



# Connectivity Module

## Current Practices in C++ Implementation

1. **Direct SQL Queries**
   - **Issues**: The use of raw SQL queries increases the risk of SQL injection attacks.
   - **Solution**: Use **ORM** to prevent SQL injection.(Dapper/Entity Framework)

3. **Error Handling**
   - **Issues**: Lack of comprehensive error handling and recovery mechanisms.
   - **Solution**: Implement proper exception handling in C# to manage database connection issues and query execution failures.

4. **Lack of Abstraction**
   - **Issues**: Direct interaction with the MySQL API makes the codebase tightly coupled with the database implementation.
   - **Solution**: Use **Repository pattern** in C# to create an abstraction layer between the application and the data access logic.

## `DataBaseMySQL.cpp`
This file contains the implementation of database connectivity and operations. Key functions and their purposes are:

1. **`ConnectDB`**
   - **Purpose**: Establishes a connection to the MySQL database.
   - **Issues**: Uses raw MySQL C API functions which require manual error handling and resource management.

2. **`ExecuteQuery`**
   - **Purpose**: Executes a SQL query.
   - **Issues**: Uses raw queries which are susceptible to SQL injection. Lacks proper exception handling.

3. **`FetchResults`**
   - **Purpose**: Fetches results from the executed query.
   - **Issues**: Manual handling of result sets and potential memory leaks.

## Repository pattern

### 1. Define Model Classes
Model classes represent the database tables. Each property in the class corresponds to a column in the database table.

### 2. Create a Repository Interface
The repository interface defines the contract for data access operations. This ensures that the business logic depends on abstractions rather than concrete implementations.

### 3. Implement the Repository Interface
The repository implementation contains the actual data access logic. This class will use Dapper or Entity Framework to interact with the database.

### 4. Dependency Injection Configuration
Configure dependency injection to manage the lifecycle of the database connection and repository.

### 5. Using the Repository
Inject the repository into services or controllers to perform database operations.

### Summary
By implementing the repository pattern, the data access logic is abstracted away from the business logic, leading to a more maintainable and testable codebase. Using Dapper or Entity Framework simplifies database interactions, reduces boilerplate code, and enhances overall code quality. This approach also improves memory management, security, logging, and error handling compared to the current C++ implementation.

