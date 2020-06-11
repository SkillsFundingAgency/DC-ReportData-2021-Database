CREATE USER [ReportDatabase_RW_User]
    WITH PASSWORD = N'$(RWUserPassword)';
GO
GRANT CONNECT TO [ReportDatabase_RW_User]
GO


