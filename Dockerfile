#https://docs.microsoft.com/es-es/aspnet/core/host-and-deploy/docker/building-net-docker-images?view=aspnetcore-5.0
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY ./WebApi/*.csproj .
RUN dotnet restore

# copy and publish app and libraries
COPY ./WebApi .
RUN dotnet publish -c release -o /app

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "WebApi.dll"]