----�˺ż�¼��
IF NOT EXISTS ( SELECT  name
                FROM    sys.tables
                WHERE   name = 'ACC01' )
    BEGIN
        CREATE TABLE [dbo].[ACC01]
            (
              [Rid] [UNIQUEIDENTIFIER] NOT NULL ,----��¼��ʶ
              [PingTai] [UNIQUEIDENTIFIER] NOT NULL ,----ƽ̨
              [PingTai_BuChong] [NVARCHAR](256) ,----ƽ̨����
              [LogonName] [NVARCHAR](256) NOT NULL ,----��¼����
              [Password] [NVARCHAR](256) NOT NULL ,----��¼����
              [TelePhone] [NVARCHAR](50) NOT NULL ,----ע���ֻ���
              [Email] [NVARCHAR](50) NOT NULL ,----ע������
              [url] [NVARCHAR](38) NOT NULL ,----��ַ
              [IsLock] [INT] NULL ----�Ƿ�������
            );
    END;

GO


