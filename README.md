## Description

PicPayApiChallenge.

## Prerequisites

- Visual Studio
- Docker Engine 17.06.0+
- .NET 7

## Docker

This will start all the services including the postgre database and pgadmin4.

```bash
$ cd PicPayApiChallenge/ ; docker-compose up -d
```

If you need to run only the database to develop something, run this:

```bash
$ cd PicPayApiChallenge/ ; docker-compose up postgres pgadmin -d
```

## Running the app

- Starts the 'PicPayApiChallenge.API' project using 'IIS Express' in Visual Studio
- Open the 'Package Manager Console' and run 'Update-Database -Verbose'

Now you database is updated with all the migrations.

## Migrations

After every Entity change, could be: edit, create, delete, etc, you must create a Migration. To do this:

- Open the 'Package Manager Console' and run 'Add-Migration [Migration name] -Verbose'
- Then you need to update the database, with 'Update-Database -Verbose'
