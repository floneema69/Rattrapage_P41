# Documentation d'Installation

## Prérequis

- Docker installé sur votre machine  
- .NET SDK installé sur votre machine  

## Installation de la Base de Données (SQL Server)

1. Téléchargez l’image Docker de SQL Server :

   ```sh
   docker pull mcr.microsoft.com/mssql/server:2022-latest
   ```

2. Lancez un conteneur SQL Server :

   ```sh
   docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=<YourStrong@Passw0rd>" \
      -p 1433:1433 --name sql1 --hostname sql1 \
      -d \
      mcr.microsoft.com/mssql/server:2022-latest
   ```

## Configuration de la Base de Données

1. Connectez-vous à SQL Server :

   ```sh
   docker exec -it sql1 /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "<YourStrong@Passw0rd>"
   ```

2. Créez une nouvelle base de données :

   ```sql
   CREATE DATABASE Rattapage;
   GO
   ```

3. Mettez à jour la chaîne de connexion dans `appsettings.json` du projet **Cars.WebUI** pour pointer vers votre base de données :

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost,1433;Database=Rattapage;User Id=SA;Password=<YourStrong@Passw0rd>;"
   }
   ```

4. Assurez-vous que **Cars.DataContext** utilise bien `appsettings.json` pour récupérer la connexion à la base de données.

## Restauration des Dépendances

Exécutez la commande suivante à la racine du projet :

```sh
dotnet restore
```

## Création et Application des Migrations

1. Naviguez vers le dossier du projet **Cars.WebUI** :

   ```sh
   cd Cars.WebUI
   ```

2. Créez une nouvelle migration :

   ```sh
   dotnet ef migrations add InitialCreate
   ```

3. Appliquez la migration et mettez à jour la base de données :

   ```sh
   dotnet ef database update
   ```

## Compilation de l'Application

```sh
dotnet build
```

## Exécution de l'Application

```sh
dotnet run --project Cars.WebUI
```

## Accès à l'Application

Ouvrez votre navigateur et accédez à :

```
http://localhost:5000
```

(ou le port défini dans vos paramètres de lancement).
