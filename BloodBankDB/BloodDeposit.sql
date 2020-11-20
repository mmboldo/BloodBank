CREATE TABLE [dbo].[BloodDeposit]
(
 [UnitId]         int NOT NULL ,
 [UnitPrice]      money NOT NULL ,
 [UnitExpiryDate] date NOT NULL ,
 [BloodTypeId]    int NOT NULL ,


 CONSTRAINT [PK_BloodDeposit] PRIMARY KEY CLUSTERED ([UnitId] ASC),
 CONSTRAINT [FK_BloodDeposit_BloodTypes_BloodTypeId] FOREIGN KEY ([BloodTypeId])  REFERENCES [dbo].[BloodTypes]([BloodTypeId])
);
GO


CREATE NONCLUSTERED INDEX [IX_BloodTypeId] ON [dbo].[BloodDeposit] 
 (
  [BloodTypeId] ASC
 )

GO