---ϵͳ�û���
IF NOT EXISTS ( SELECT  name
                FROM    sys.tables
                WHERE   name = 'UserInfo' )
    BEGIN
        CREATE TABLE [dbo].[UserInfo]
            (
              [Rid] [UNIQUEIDENTIFIER] NOT NULL ,----��¼��ʶ
              [UserName] [NVARCHAR](256) NOT NULL ,----�û���
              [LogonName] [NVARCHAR](256) NOT NULL ,----��¼����
              [PASSWORD] [NVARCHAR](256) NOT NULL ,----��¼����
              [TelePhone] [NVARCHAR](50) NOT NULL ,----�ֻ���
            );
    END;

GO