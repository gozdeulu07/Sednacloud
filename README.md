Database bağlantı ayarlarını kontrol edebilirsiniz. 
DesignTimeDbContextFactory.cs üzerinde .

Migrationları Yüklemek için
Konsol üzerinden
Insfrastructure klasörüne gidip.

dotnet ef migrations add migrationadı --project SednaReservationAPI.Persistence

dotnet ef database update --project SednaReservationAPI.Persistence
