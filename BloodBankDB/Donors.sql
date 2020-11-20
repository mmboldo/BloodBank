CREATE TABLE [dbo].[Donors]
(
 [DonorId]        int NOT NULL ,
 [DonorFirstName] nvarchar(50) NOT NULL ,
 [DonorLastName]  nvarchar(50) NOT NULL ,
 [DonorBirthday]  date NOT NULL ,
 [DonorAddress]   nvarchar(50) NOT NULL ,
 [DonorPhone]     varchar(10) NOT NULL ,
 [BloodTypeId]    int NOT NULL ,


 CONSTRAINT [PK_donors] PRIMARY KEY CLUSTERED ([DonorId] ASC),
 CONSTRAINT [FK_Donors_BloodTypes_BloodTypeId] FOREIGN KEY ([BloodTypeId])  REFERENCES [dbo].[BloodTypes]([BloodTypeId])
);
GO


CREATE NONCLUSTERED INDEX [IX_BloodTypeId] ON [dbo].[Donors] 
 (
  [BloodTypeId] ASC
 )

GO