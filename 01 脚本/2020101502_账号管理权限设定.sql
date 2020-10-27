---账号归属用户表
IF NOT EXISTS ( SELECT  name
                FROM    sys.tables
                WHERE   name = 'UserInfo_ACC01' )
    BEGIN
        CREATE TABLE [dbo].[UserInfo_ACC01]
            (
              [Rid] [UNIQUEIDENTIFIER] NOT NULL ,----记录标识
              [UserInfo_Rid] [UNIQUEIDENTIFIER] NOT NULL ,----记录标识
              [Rid] [UNIQUEIDENTIFIER] NOT NULL ,----记录标识 
            );
    END;

GO