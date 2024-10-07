FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["BookStore/BookStore.csproj", "BookStore/"]
RUN dotnet restore "BookStore/BookStore.csproj"

COPY . .
WORKDIR "/src/BookStore"
RUN dotnet build "BookStore.csproj" -c Release -o /app/build

RUN dotnet publish "BookStore.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "BookStore.dll"]
