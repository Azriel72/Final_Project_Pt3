# Build Stage
FROM docker pull mcr.microsoft.com/dotnet/sdk:8.0 . AS build
WORKDIR /source
COPY . .
RUN dotnet restore "./MyWebApplication1/MyWebApplication1.csproj" --disable parallel
RUN dotnet publish "./MyWebApplication1/MyWebApplication1.csproj" -c Release -o /app --no-restore

# Serve Stage
FROM docker pull mcr.microsoft.com/dotnet/sdk:8.0 .
WORKDIR /app
COPY --from=build /app ./

EXPOSE 5000

ENTRYPOINT ["dotnet", "MyWebApplication1.dll"]
