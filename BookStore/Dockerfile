# Use the .NET SDK to build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the project files and restore dependencies
COPY ["BookStore/BookStore.csproj", "BookStore/"]
RUN dotnet restore "BookStore/BookStore.csproj"

# Copy the entire project and build it
COPY . .
WORKDIR "/src/BookStore"
RUN dotnet build "BookStore.csproj" -c Release -o /app/build

# Run tests during the build
# If you have a separate test project, reference it here; otherwise, run tests for the main project
RUN dotnet test "BookStore.csproj" --no-build --verbosity normal

# Publish the application
RUN dotnet publish "BookStore.csproj" -c Release -o /app/publish

# Use the ASP.NET runtime to run the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "BookStore.dll"]
