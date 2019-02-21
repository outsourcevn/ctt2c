### AppPortal

### Developer
- install [.NET Core SDK 2.1.405](https://github.com/dotnet/core/blob/master/release-notes/2.1/2.1.4/2.1.4.md)

### database

Sql script update database

#### InitDb
```
dotnet ef migrations add InitIdentityModel --context AppIdentityDbContext -p ..\AppPortal.Infrastructure\AppPortal.Infrastructure.csproj -o ..\AppPortal.Infrastructure\Identity\Migrations -s .\AppPortal.AdminSite.csproj
dotnet ef migrations add InitAppPortalModel --context AppDataContext -p ..\AppPortal.Infrastructure\AppPortal.Infrastructure.csproj -o ..\AppPortal.Infrastructure\Data\Migrations -s .\AppPortal.AdminSite.csproj
```

### Add migrations
```
 Add-Migration "AddNewTableVanban" -c AppDataContext -o Data/Migrations
 Update-Database -Migration AddNewTableNewsPreview -c "AppDataContext" 
 Update-Database -c "AppDataContext" 
```


### Depoy
- Sql: 2008R2 or N
- [ASP.NET Core Runtime](https://download.microsoft.com/download/A/7/8/A78F1D25-8D5C-4411-B544-C7D527296D5E/dotnet-hosting-2.1.4-win.exe)
### demo
- http://demo.eportal.today
- http://cdn.eportal.today
- http://apinode.eportal.today
- http://cms.eportal.today