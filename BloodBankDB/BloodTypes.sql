CREATE TABLE [dbo].[BloodTypes]
(
 [BloodTypeId]  int NOT NULL ,
 [BloodType]    char(10) NOT NULL ,
 [PricePerUnit] real NOT NULL ,


 CONSTRAINT [PK_BloodTypes] PRIMARY KEY CLUSTERED ([BloodTypeId] ASC)
);
GO