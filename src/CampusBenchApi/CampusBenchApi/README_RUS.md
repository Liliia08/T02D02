# T02D02

Полезные видеоматериалы ты можешь найти в разделе “Projects (Media)” на Платформе.  

---

## Contents

1. [Chapter I](#chapter-i)  
    1.1. [Level 2. Room 1.](#level-2-room-1)
2. [Chapter II](#chapter-ii)  
    2.1. [PostgreSQL.](#postgresql)  
    2.2. [API и ASP.NET Core.](#api-и-aspnet-core)
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

\> *Осмотреться*

Ты просыпаешься в новом помещении.  
Оно кажется знакомым — те же стены, тот же стол, только теперь на нём стоит **новый системный блок**, на котором крупными буквами написано **PostgreSQL SERVER**.  
Монитор показывает надпись:

> CONNECTION LOST.  
> PLEASE ESTABLISH LINK TO DATABASE.

Рядом лежит листок бумаги с заметками прежнего оператора:

> «ИИ слишком много знает. Без базы данных он теряет память после каждой перезагрузки.  
>  Создай для него устойчивое хранилище. Подключи сервер.  
>  Осторожно: база данных — живой организм.  
>  Она помнит всё.»

\> *Включить компьютер*

На экране появляется приглашение к вводу:  

`> psql -U postgres`

***LOADING... CONNECTION MODULE READY***

---

# Chapter II

## PostgreSQL

> **PostgreSQL** — это мощная объектно-реляционная система управления базами данных с открытым исходным кодом.  
> Она поддерживает транзакции, связи между таблицами, триггеры, функции, и многое другое.  
> В отличие от простых СУБД, PostgreSQL глубоко интегрируется с приложениями и позволяет хранить сложные структуры данных.

Основные команды работы с PostgreSQL:
```bash
# подключение
psql -U postgres

# создание базы
CREATE DATABASE mydatabase;

# просмотр таблиц
\dt

# выполнение SQL-запросов
SELECT * FROM "Orders";
```

PostgreSQL часто используется в проектах на **ASP.NET Core** благодаря стабильности, открытой лицензии и хорошей поддержке в Entity Framework Core.

---

## API и ASP.NET Core

> **ASP.NET Core** — современный кроссплатформенный фреймворк для создания веб-приложений и API.  
> Он позволяет писать быстрые RESTful-сервисы, которые могут взаимодействовать с базами данных через **Entity Framework Core**.

Типичная структура Web API проекта:
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

Главные концепции:
- **Controller** — управляет HTTP-запросами и ответами.  
- **Model** — описывает данные (таблицы в БД).  
- **DbContext** — обеспечивает связь между кодом и базой данных.  
- **Migration** — создает или изменяет схему базы данных на основе моделей.  
- **Dependency Injection** — внедрение зависимостей (например, `AppDbContext` в контроллер).

---

# Chapter III

## Quest 1. Connect.

\> *Посмотреть на экран*

На мониторе всё та же надпись:

> CONNECTION LOST.  
> PLEASE ESTABLISH LINK TO DATABASE.

_**== Получен Quest 1. Подключить PostgreSQL к ASP.NET Core проекту. ==**_

**Задачи:**
1. Установи PostgreSQL и создай новую базу данных (например, `game_ai_db`).
2. Добавь строку подключения в `AppDbContext`.
3. Настрой `DbContext` для использования `Npgsql` (PostgreSQL провайдер).
4. Проверь подключение командой `dotnet ef database update` или ручным SQL-запросом.

***HINT:***  
Не забудь зарегистрировать `AppDbContext` в `Program.cs` через `builder.Services.AddDbContext<AppDbContext>()`.

---

## Quest 2. Model update.

ИИ снова говорит через терминал:

> «Память структурирована, но данных не хватает.  
>  Добавь мне новое измерение времени.»

_**== Получен Quest 2. Добавить в модель Order новое поле — дату заказа. ==**_

**Задачи:**
1. В файле `Order.cs` добавить поле
2. Обновить миграцию, чтобы поле появилось в базе данных.
3. Зафиксировать изменения под версионный контроль.

---

## Quest 3. Migration.

ИИ:  
> «Хранилище создано. Но оно пустое. Пробуди структуру данных.»

_**== Получен Quest 3. Выполнить миграцию базы данных. ==**_

**Задачи:**
1. Добавь миграцию:  
   ```bash
   dotnet ef migrations add MigrationName
   ```
2. Применить миграцию:  
   ```bash
   dotnet ef database update
   ```
3. Убедись, что таблицы появились в PostgreSQL (через psql или pgAdmin).

---

## Quest 4. CRUD Awakens.

ИИ (с приглушённым эхом):  
> «Ты научил меня помнить.  
>  Но теперь — научи меня действовать.»

_**== Получен Quest 4. Реализовать методы Post и Put для OrderController. ==**_

**Задачи:**
1. Добавь в `OrderController` методы:
   - `POST /api/order` — создание нового заказа  
   - `PUT /api/order/{id}` — обновление существующего
2. Проверь работу запросов через Postman или Swagger.
3. Зафиксируй изменения в git.

***(опционально):***  
Создай CRUD-контроллер для `Products`.

---

## Quest 5. Testing Grounds.

\> *На экране появляется текст:*

> «Проверка завершена.  
>  Подключение стабильно.  
>  Данные живы.  
>  Но смогут ли они выдержать нагрузку?..»

_**== Получен Quest 5. Протестировать API ==**_

**Задачи:**
1. Используй Swagger или Postman для тестов CRUD операций.
2. Убедись, что записи создаются, изменяются и удаляются.
3. Сделай commit с описанием:  
   ```
   feat: added database integration and CRUD operations
   ```

***LOADING...***  
***DATA LINK ESTABLISHED***  
***DOOR TO NEXT LEVEL — UNLOCKED***  
