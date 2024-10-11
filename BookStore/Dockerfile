# Use the .NET SDK to build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the project files and restore dependencies
COPY ["BookStore/BookStore.csproj", "BookStore/"]
COPY ["BookStore.Tests/BookStore.Tests.csproj", "BookStore.Tests/"]
RUN dotnet restore "BookStore/BookStore.sln"

# Copy the entire project and build it
COPY . .
WORKDIR "/src/BookStore"
RUN dotnet build "BookStore.csproj" -c Release -o /app/build

# Run tests during the build
WORKDIR "/src/BookStore.Tests"
RUN dotnet test "BookStore.Tests.csproj" --no-build --verbosity normal

# Publish the application
WORKDIR "/src/BookStore"
RUN dotnet publish "BookStore.csproj" -c Release -o /app/publish

# Use the ASP.NET runtime to run the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "BookStore.dll"]
