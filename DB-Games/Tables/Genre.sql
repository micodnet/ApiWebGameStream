CREATE TABLE [dbo].[Genre]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(10) NULL, 
    CONSTRAINT [FK_Genre_Id] FOREIGN KEY (Id) REFERENCES [Jeux]([Id])
)

GO

CREATE TRIGGER [dbo].[Trigger_Genre]
    ON [dbo].[Genre]
    FOR DELETE, INSERT, UPDATE
    AS
    BEGIN
        SET NoCount ON
    END