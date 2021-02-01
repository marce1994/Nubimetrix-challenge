# Como correr la app

## Con docker

- Correr desde la raiz del proyecto ```docker-compose up```
- Va a estar disponible en http://localhost:80

## En windows

### Dependencias:
- [.Net SDK 5.0.2](https://dotnet.microsoft.com/download/dotnet/5.0)
- MSSQLServer

### Configuracion base de datos
Teniento lo anterior, hay que modificar el ConnectionString de ```appsettings.json```
```
"ConnectionStrings":
{
    "AppDB": "Server=localhost;Database=AppDB;User=sa;Password=Password123!;" // <---
}
```
### Correr la app

Desde la raiz del proyecto ejecutar
``` dotnet run ```

Va a estar disponible en https://localhost:5001

