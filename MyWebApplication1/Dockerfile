# Stage 1: Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /webapp

EXPOSE 80
EXPOSE 5024

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet clean
RUN dotnet restore --force

# Copy everything else and build
COPY . .
RUN dotnet publish -c Release -o out

# Stage 2: Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /webapp
COPY --from=build /webapp/out .
ENTRYPOINT ["dotnet", "MyWebApplication1.dll"]
