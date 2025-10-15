# T02D02

You can find useful video materials in the “Projects (Media)” section on the Platform.  

---

## Contents

1. [Chapter I](#chapter-i)  
    1.1. [Level 2. Room 1.](#level-2-room-1)
2. [Chapter II](#chapter-ii)  
    2.1. [PostgreSQL.](#postgresql)  
    2.2. [API and ASP.NET Core.](#api-and-aspnet-core)
3. [Chapter III](#chapter-iii)  
    3.1. [Quest 1. Connect.](#quest-1-connect)  
    3.2. [Quest 2. Model update.](#quest-2-model-update)  
    3.3. [Quest 3. Migration.](#quest-3-migration)  
    3.4. [Quest 4. CRUD Awakens.](#quest-4-crud-awakens)  
    3.5. [Quest 5. Testing Grounds.](#quest-5-testing-grounds)  

---

# Chapter I

## Level 2. Room 1.

***LOADING LEVEL 2...***

***SUCCESSFULLY LOADED.***

\> *Look around*

You wake up in a new room.  
It feels familiar — the same walls, the same desk, but now there’s a **new system unit** on it, with the words **PostgreSQL SERVER** engraved in large letters.  
The monitor displays the message:

> CONNECTION LOST.  
> PLEASE ESTABLISH LINK TO DATABASE.

Next to the monitor lies a piece of paper with notes from the previous operator:

> “The AI knows too much. Without a database, it loses its memory after every reboot.  
>  Create a stable storage for it. Connect the server.  
>  Be careful: the database is alive.  
>  It remembers everything.”

\> *Turn on the computer*

The screen displays a prompt:  

`> psql -U postgres`

***LOADING... CONNECTION MODULE READY***

---

# Chapter II

## PostgreSQL

> **PostgreSQL** is a powerful open-source object-relational database management system.  
> It supports transactions, relationships between tables, triggers, functions, and much more.  
> Unlike simple databases, PostgreSQL integrates deeply with applications and allows storing complex data structures.

Basic PostgreSQL commands:
```bash
# connect
psql -U postgres

# create database
CREATE DATABASE mydatabase;

# show tables
\dt

# execute SQL queries
SELECT * FROM "Orders";
```

PostgreSQL is often used in **ASP.NET Core** projects for its stability, open license, and great Entity Framework Core support.

---

## API and ASP.NET Core

> **ASP.NET Core** is a modern cross-platform framework for building web applications and APIs.  
> It enables you to write fast RESTful services that can interact with databases via **Entity Framework Core**.

Typical Web API project structure:
```
/Controllers
    OrderController.cs
    ProductController.cs
/Models
    Order.cs
    Product.cs
/Context
    AppDbContext.cs
Program.cs
appsettings.json
```

Main concepts:
- **Controller** — handles HTTP requests and responses.  
- **Model** — describes data (tables in the database).  
- **DbContext** — provides a link between code and the database.  
- **Migration** — creates or modifies the database schema based on models.  
- **Dependency Injection** — injects dependencies (e.g. `AppDbContext` into controllers).

---

# Chapter III

## Quest 1. Connect.

\> *Look at the screen*

The monitor still shows the same message:

> CONNECTION LOST.  
> PLEASE ESTABLISH LINK TO DATABASE.

_**== Quest 1 received. Connect PostgreSQL to your ASP.NET Core project. ==**_

**Tasks:**
1. Install PostgreSQL and create a new database (for example, `game_ai_db`).
2. Add the connection string in `AppDbContext`.
3. Configure the `DbContext` to use `Npgsql` (PostgreSQL provider).
4. Verify the connection using `dotnet ef database update` or a manual SQL query.

***HINT:***  
Don’t forget to register `AppDbContext` in `Program.cs` via `builder.Services.AddDbContext<AppDbContext>()`.

---

## Quest 2. Model update.

The AI speaks again through the terminal:

> “Memory structured, but data insufficient.  
>  Add a new dimension of time.”

_**== Quest 2 received. Add a new field to the Order model — order date. ==**_

**Tasks:**
1. In `Order.cs`, add a new property.
2. Update the migration so the field appears in the database.
3. Commit the changes to version control.

---

## Quest 3. Migration.

AI:  
> “Storage created. But it is empty. Awaken the structure of data.”

_**== Quest 3 received. Perform database migration. ==**_

**Tasks:**
1. Add a migration:  
   ```bash
   dotnet ef migrations add MigrationName
   ```
2. Apply the migration:  
   ```bash
   dotnet ef database update
   ```
3. Make sure the tables appeared in PostgreSQL (via psql or pgAdmin).

---

## Quest 4. CRUD Awakens.

AI (with a faint echo):  
> “You taught me to remember.  
>  Now teach me to act.”

_**== Quest 4 received. Implement Post and Put methods in OrderController. ==**_

**Tasks:**
1. Add methods to `OrderController`:
   - `POST /api/order` — create a new order  
   - `PUT /api/order/{id}` — update an existing order
2. Test endpoints via Postman or Swagger.
3. Commit the changes to git.

***(optional):***  
Create a CRUD controller for `Products`.

---

## Quest 5. Testing Grounds.

\> *The screen displays:*

> “Verification complete.  
>  Connection stable.  
>  Data alive.  
>  But can they withstand the load?..”

_**== Quest 5 received. Test the API. ==**_

**Tasks:**
1. Use Swagger or Postman to test CRUD operations.
2. Ensure records can be created, updated, and deleted.
3. Commit your changes with message:  
   ```
   feat: added database integration and CRUD operations
   ```

***LOADING...***  
***DATA LINK ESTABLISHED***  
***DOOR TO NEXT LEVEL — UNLOCKED***  
