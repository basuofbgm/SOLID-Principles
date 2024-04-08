S - Single Responsibility Principle (SRP), Ensure a class has only one responsibility and thus only one reason to change, AccountInterest can be extended to support different types of accounts without modifying existing interest calculation logic, promoting flexibility in adding new account types.
O - Open/Closed Principle (OCP), Classes should be open for extension but closed for modification. AccountInterest can be extended to support different types of accounts without modifying existing interest calculation logic, promoting flexibility in adding new account types.
L - Liskov Substitution Principle (LSP), Subtypes must be substitutable for their base types without affecting the application. ApplyInterest works correctly regardless of the AccountInterest subtype, allowing new interest calculation strategies to be introduced without changing the existing application behavior.
I - Interface Segregation Principle (ISP), Clients should not be forced to depend on interfaces they don't use. TransferTransaction implements both ITransaction for executing the transaction and IReversibleTransaction for reversing it, while other transaction types might only implement ITransaction if they cannot be reversed.
D - Dependency Inversion Principle (DIP), High-level modules should not depend on low-level modules. Both should depend on abstractions. AccountService depends on the IAccountRepository abstraction, not a concrete class. This allows the storage mechanism for accounts to change (e.g., from a local database to a cloud service) without modifying the AccountService logic.
