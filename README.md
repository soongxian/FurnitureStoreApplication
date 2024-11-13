# FurnitureStoreApplication 🏬 

This originally created web-based application is created as a one stop platform for user to purchase different types of furniture. (Currently still in progress with more features to be added)

## Learning Checkpoint: 📜
1. Utilize Entity Framework to create a database in SQL Server (🚧)
2. Develop CRUD functions with C# .NET 8.0 (🚧)
   - Use DTOs to define the data to be included in API responses and requests. (🚧)
   - Use the Repository pattern to implement data access methods. (🚧)
   - Use Services to implement business logic. (🚧)
3. Create a user interface with ReactJS (🚧)
   - Homepage (🚧)
   - Login/Register (🚧)
   - Catalogue (🚧)
   - Cart/Checkout (🚧) 

## Features 🛠️
1. Login/Register page for employees and customers. (🚧)
2. Catalogue page showing furniture according to categories. (🚧)
3. Cart/Checkout page to add and pay for furniture. (🚧)

## Tips and Guide: 😎
#### Create database in SQL server
1. Launch `backend.sln` inside the `FurnitureStoreApplication/backend` folder. 
2. Open the terminal and run the following command:  
   `dotnet ef migrations add initial --project FurnitureStore.Data --startup-project FurnitureStore.API` 
3. Run another command:  
   `dotnet ef database update --project FurnitureStore.Data --startup-project FurnitureStore.API`
4. The database will be created in SQL Server.

#### Knowledge Base
1. DTOs are used to define only the necessary information to be included, preventing unnecessary data from being exposed and shaping the data into a specific format.
2. The Repository acts as the data access layer to interact with the database, with the interface defining the methods for data operations for encapsulating the data access logic, together with data access method to interact directly with the database.
3. Services contain the business logic and call the repository for data access.
