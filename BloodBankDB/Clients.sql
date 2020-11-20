CREATE TABLE [dbo].[Clients]
(
 [ClientId]        int NOT NULL ,
 [ClientFirstName] nvarchar(50) NOT NULL ,
 [ClientLastName]  nvarchar(50) NOT NULL ,


 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED ([ClientId] ASC)
);
GO