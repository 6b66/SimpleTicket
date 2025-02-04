FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /App
COPY ./SimpleTickets .
RUN dotnet restore ./SimpleTickets.csproj
RUN dotnet publish ./SimpleTickets.csproj -c Release -o out --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build /App ./

ENTRYPOINT ["dotnet", "out/SimpleTickets.dll"]