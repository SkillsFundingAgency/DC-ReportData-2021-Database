dotnet.exe ef dbcontext scaffold "Server=.\;Database=ESFA.DC.PeriodEnd.DataPerist.Database;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -c ReportDataContext --schema dbo --force --startup-project .  --project ..\ESFA.DC.ReportData.Model --verbose

pause
