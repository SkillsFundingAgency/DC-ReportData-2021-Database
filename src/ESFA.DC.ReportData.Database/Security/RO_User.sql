﻿CREATE USER [ReportDatabase_RO_User]
    WITH PASSWORD = N'$(ROUserPassword)';
GO
GRANT CONNECT TO [ReportDatabase_RO_User]
GO


