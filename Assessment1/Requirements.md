User Story: Online Banking System

As a bank customer, I want to leverage the convenience of online banking to perform various transactions and banking activities, 
including balance inquiry, funds transfer, and request services like cheque book issuance and address change. 
Additionally, I want the ability to view monthly and annual statements for my account and apply for loans and cashier monitors money flows.
The bank Manager must be able to manage workers with access to promotions or salary of bank employees.

Functional Requirements

Various functional modules that can be implemented by the product are listed below.

1. Login:
Customer logins by entering customer name & a login pin.

2. Validation:
When a customer enters the ATM card, its validity must be ensured. The customer is allowed to enter the valid PIN. The validation can be for the following conditions:
Validation for lost or stolen, Validation for card’s expiry date, Validation for PIN

3. Get balance information:
The system must be networked to the bank’s computer, and the updated database of every customer is maintained with the bank. The balance information of every account is available in the database and can be displayed to the customer.

4. Payment of Money:
A customer is allowed to enter the amount they wish to withdraw. If the entered amount is less than the available balance and after withdrawal, the minimum required balance is maintained, allow the transaction.

5. Transfer of Money:
The customer can deposit or transfer the desired amount of money.

6. Transaction Report:
The bank statement showing credit and debit information of the corresponding account must be printed by the machine.

7. Request Services:
Customers can request services such as cheque book issuance, change of address, and stop payment of cheques.

8. Mini Statements:
Customers can view monthly and annual statements for their accounts.

9.Technical Issues:
This product will work on client-server architecture and will require an internet server capable of running PHP applications. The product should support commonly used browsers such as Internet Explorer, Mozilla Firefox.

10. Apply Loan:
Customer applies for Loan and Manager approves the same.


Non-Functional Requirements

1. Reliability:
The application should be highly reliable, generating all updated information in the correct order.

2. High Availability:
Any information about the account should be quickly available from any computer to the authorized user. The previously visited customer’s data must not be cleared.

3. Maintainability:
The application should be maintainable so that any new requirement can be easily incorporated into an individual module.

4. Portability:
The application should be portable on any Windows-based system and should not be machine-specific.

5. Performance:
Response time for content creation and editing should be under 2 seconds.
The system should handle concurrent users without significant performance degradation.

6. Usability:
Intuitive user interface for easy adoption.
User documentation for quick onboarding and reference.

7. Scalability:
Ability to handle a growing volume of content and users.
Easily expandable architecture to accommodate future enhancements.







USE CASE DIAGRAM:



