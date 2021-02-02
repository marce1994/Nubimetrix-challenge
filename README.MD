# Como correr la app
## Clonar el repositorio
- ```git clone https://github.com/marce1994/Nubimetrix-challenge.git```
# Con docker
- ```cd Nubimetrix-challenge/WebApi```
- ```docker-compose up```

Luego de un tiempo(luego de buildear, descargar contenedores, etc) deberia estar disponible en ```http://localhost:80```

# En Windows (similar en otras plataformas tambien)

### Dependencias:

- [.Net SDK 5.0](https://dotnet.microsoft.com/download/dotnet/5.0) Para la API.
- [.Net SDK 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1) Para la app de consola.
- MSSQLServer (Si se tiene docker se puede utilizar: ```docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Password123!' -e 'MSSQL_PID=Express' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-latest-ubuntu```)

## Correr API
### Configuracion base de datos

Teniento lo anterior, hay que modificar el ConnectionString de ```Nubimetrix-challenge/WebApi/appsettings.json```

```
"ConnectionStrings":
{
    "AppDB": "Server=localhost;Database=AppDB;User=sa;Password=Password123!;" // <---
}
```

- desde ```Nubimetrix-challenge/WebApi``` ejecutar lo siguiente en linea de comandos: ``` dotnet run ```
- Va a estar disponible en ```https://localhost:5001```

## Correr app consola

- Parado en ```Nubimetrix-challenge/ConsoleApp``` ejecutar ```dotnet run``` en linea de comandos.
- En la misma carpeta deberian aparecer 2 archivos, un .json y un .csv conteniendo lo requerido en el challenge 4.