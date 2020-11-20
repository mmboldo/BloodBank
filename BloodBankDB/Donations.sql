CREATE TABLE [dbo].[Donations]
(
 [DonationId]          int NOT NULL ,
 [DonationBloodVolume] real NOT NULL ,
 [MedicalReport]       nvarchar(100) NOT NULL ,
 [BloodTypeId]         int NOT NULL ,
 [DonorId]             int NOT NULL ,
 [DonationDate]        datetime NOT NULL ,


 CONSTRAINT [PK_Donations] PRIMARY KEY CLUSTERED ([DonationId] ASC),
 CONSTRAINT [FK_Donations_BloodTypes_BloodTypeId] FOREIGN KEY ([BloodTypeId])  REFERENCES [dbo].[BloodTypes]([BloodTypeId]),
 CONSTRAINT [FK_Donations_Donors_DonorId] FOREIGN KEY ([DonorId])  REFERENCES [dbo].[Donors]([DonorId])
);
GO


CREATE NONCLUSTERED INDEX [IX_BloodTypeId] ON [dbo].[Donations] 
 (
  [BloodTypeId] ASC
 )

GO

CREATE NONCLUSTERED INDEX [IX_DonorId] ON [dbo].[Donations] 
 (
  [DonorId] ASC
 )

GO