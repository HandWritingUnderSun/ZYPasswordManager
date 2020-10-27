----账号记录表，
IF NOT EXISTS ( SELECT  name
                FROM    sys.tables
                WHERE   name = 'ACC01' )
    BEGIN
        CREATE TABLE [dbo].[ACC01]
            (
              [Rid] [UNIQUEIDENTIFIER] NOT NULL ,----记录标识
              [PingTai] [UNIQUEIDENTIFIER] NOT NULL ,----平台
              [PingTai_BuChong] [NVARCHAR](256) ,----平台补充
              [LogonName] [NVARCHAR](256) NOT NULL ,----登录名称
              [Password] [NVARCHAR](256) NOT NULL ,----登录密码
              [TelePhone] [NVARCHAR](50) NOT NULL ,----注册手机号
              [Email] [NVARCHAR](50) NOT NULL ,----注册邮箱
              [url] [NVARCHAR](38) NOT NULL ,----网址
              [IsLock] [INT] NULL ----是否已锁定
            );
    END;

GO


