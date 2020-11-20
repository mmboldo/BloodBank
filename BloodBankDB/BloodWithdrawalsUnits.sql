CREATE TABLE [dbo].[BloodWithdrawalUnits]
(
 [BloodWithdrawalUnitsId] int NOT NULL ,
 [UnitId]                 int NOT NULL ,
 [BloodWithdrawalId]      int NOT NULL ,


 CONSTRAINT [PK_bloodwithdrawalunits] PRIMARY KEY CLUSTERED ([BloodWithdrawalUnitsId] ASC),
 CONSTRAINT [FK_BloodWithdrawalUnits_BloodDeposit_UnitId] FOREIGN KEY ([UnitId])  REFERENCES [dbo].[BloodDeposit]([UnitId]),
 CONSTRAINT [FK_BloodWithdrawalUnits_BloodWithdrawals_BloodWithdrawalId] FOREIGN KEY ([BloodWithdrawalId])  REFERENCES [dbo].[BloodWithdrawals]([BloodWithdrawalId])
);
GO


CREATE NONCLUSTERED INDEX [IX_UnitId] ON [dbo].[BloodWithdrawalUnits] 
 (
  [UnitId] ASC
 )

GO

CREATE NONCLUSTERED INDEX [IX_BloodWithdrawalId] ON [dbo].[BloodWithdrawalUnits] 
 (
  [BloodWithdrawalId] ASC
 )

GO