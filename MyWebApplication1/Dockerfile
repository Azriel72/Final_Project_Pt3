# Utiliza la imagen base del SDK de .NET
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia el archivo csproj y restaura las dependencias
COPY MyWebApplication1/*.csproj ./MyWebApplication1/
WORKDIR /app/MyWebApplication1
RUN dotnet restore

# Copia el resto de los archivos y compila la aplicación
WORKDIR /app
COPY . .
WORKDIR /app/MyWebApplication1
RUN dotnet publish -c Release -o out

# Construye la imagen final del contenedor
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/MyWebApplication1/out ./

# Expone el puerto y ejecuta la aplicación
EXPOSE 80
EXPOSE 5024
ENTRYPOINT ["dotnet", "MyWebApplication1.dll"]
