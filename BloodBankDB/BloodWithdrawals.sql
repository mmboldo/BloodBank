CREATE TABLE [dbo].[BloodWithdrawals]
(
 [BloodWithdrawalId]   int NOT NULL ,
 [BloodWithdrawalDate] datetime NOT NULL ,
 [TransactionValue]    real NOT NULL ,
 [UnitQuantity]        int NOT NULL ,
 [ClientId]            int NOT NULL ,


 CONSTRAINT [PK_BloodWithdrawals] PRIMARY KEY CLUSTERED ([BloodWithdrawalId] ASC),
 CONSTRAINT [FK_BloodWithdrawals_Clients_ClientId] FOREIGN KEY ([ClientId])  REFERENCES [dbo].[Clients]([ClientId])
);
GO


CREATE NONCLUSTERED INDEX [IX_ClientId] ON [dbo].[BloodWithdrawals] 
 (
  [ClientId] ASC
 )

GO