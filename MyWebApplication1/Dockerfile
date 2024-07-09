FROM docker pull mcr.microsoft.com/dotnet/sdk:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM docker pull mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["MyWebApplication1/MyWebApplication1.csproj", "MyWebApplication1/"]
RUN dotnet restore "MyWebApplication1/MyWebApplication1.csproj"
COPY . .
WORKDIR "/src/MyWebApplication1"
RUN dotnet build "MyWebApplication1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet build "MyWebApplication1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyWebApplication1.dll"]