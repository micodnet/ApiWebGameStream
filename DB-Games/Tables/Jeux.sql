CREATE TABLE [dbo].[Jeux]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] VARCHAR(50) NULL, 
    [AnneeSortie] DATETIME2 NULL, 
    [Note] INT NULL, 
    [Genre_Id] INT NULL, 
    [Description] VARCHAR(100) NULL
)

GO

CREATE TRIGGER [dbo].[Trigger_Jeux]
    ON [dbo].[Jeux]
    FOR DELETE, INSERT, UPDATE
    AS
    BEGIN
        SET NoCount ON
    END