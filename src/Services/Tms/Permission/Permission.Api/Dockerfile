FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
#COPY tms.sln ./
#COPY src/Services/Tms/Permission/Permission.Api/Permission.Api.csproj src/Services/Tms/Permission/Permission.Api/
COPY . .
RUN dotnet restore -nowarn:msb3202,nu1503

WORKDIR /src/src/Services/Tms/Permission/Permission.Api
RUN dotnet build --no-restore -c Release -o /app

FROM build AS publish
RUN dotnet publish --no-restore -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Permission.Api.dll"]
