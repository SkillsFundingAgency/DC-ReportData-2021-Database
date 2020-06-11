dotnet.exe ef dbcontext scaffold "Server=.\;Database=ESFA.DC.ReportData.Database;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -c ReportDataContext --schema dbo --force --startup-project .  --project ..\ESFA.DC.ReportData.Model --verbose

pause
