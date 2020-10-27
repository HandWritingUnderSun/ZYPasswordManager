---系统用户表
IF NOT EXISTS ( SELECT  name
                FROM    sys.tables
                WHERE   name = 'UserInfo' )
    BEGIN
        CREATE TABLE [dbo].[UserInfo]
            (
              [Rid] [UNIQUEIDENTIFIER] NOT NULL ,----记录标识
              [UserName] [NVARCHAR](256) NOT NULL ,----用户名
              [LogonName] [NVARCHAR](256) NOT NULL ,----登录名称
              [PASSWORD] [NVARCHAR](256) NOT NULL ,----登录密码
              [TelePhone] [NVARCHAR](50) NOT NULL ,----手机号
            );
    END;

GO