CREATE TABLE [dbo].[Persons] (
    [Id]       INT           NOT NULL,
    [FullName] NVARCHAR (50) NULL,
    [Email]    NVARCHAR (50) NULL,
    [Phone]    VARCHAR (25)  NULL,
    [Gender]   BIT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

