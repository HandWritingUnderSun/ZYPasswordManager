---�˺Ź����û���
IF NOT EXISTS ( SELECT  name
                FROM    sys.tables
                WHERE   name = 'UserInfo_ACC01' )
    BEGIN
        CREATE TABLE [dbo].[UserInfo_ACC01]
            (
              [Rid] [UNIQUEIDENTIFIER] NOT NULL ,----��¼��ʶ
              [UserInfo_Rid] [UNIQUEIDENTIFIER] NOT NULL ,----��¼��ʶ
              [Rid] [UNIQUEIDENTIFIER] NOT NULL ,----��¼��ʶ 
            );
    END;

GO