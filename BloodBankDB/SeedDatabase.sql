/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT INTO [dbo].[BloodTypes] ([BloodTypeId],[BloodType],[PricePerUnit]) VALUES (1, 'A+',  150.00)
INSERT INTO [dbo].[BloodTypes] ([BloodTypeId],[BloodType],[PricePerUnit]) VALUES (2, 'A-',  300.00)
INSERT INTO [dbo].[BloodTypes] ([BloodTypeId],[BloodType],[PricePerUnit]) VALUES (3, 'B+',  300.00)
INSERT INTO [dbo].[BloodTypes] ([BloodTypeId],[BloodType],[PricePerUnit]) VALUES (4, 'B-',  400.00)
INSERT INTO [dbo].[BloodTypes] ([BloodTypeId],[BloodType],[PricePerUnit]) VALUES (5, 'AB+', 400.00)
INSERT INTO [dbo].[BloodTypes] ([BloodTypeId],[BloodType],[PricePerUnit]) VALUES (6, 'AB-', 500.00)
INSERT INTO [dbo].[BloodTypes] ([BloodTypeId],[BloodType],[PricePerUnit]) VALUES (7, 'O+',  150.00)
INSERT INTO [dbo].[BloodTypes] ([BloodTypeId],[BloodType],[PricePerUnit]) VALUES (8, 'O-',  400.00)


GO
insert into [dbo].[Donors] ([DonorId], [DonorFirstName], [DonorLastName], [DonorBirthday], [DonorAddress], [DonorPhone], [BloodTypeId]) values (1, 'Pierre', 'Lovelady', '09/13/1994', 'plovelady0@vkontakte.ru', '4105654504', '7');
insert into [dbo].[Donors] ([DonorId], [DonorFirstName], [DonorLastName], [DonorBirthday], [DonorAddress], [DonorPhone], [BloodTypeId]) values (2, 'Winnifred', 'Halbeard', '12/11/1980', 'whalbeard1@jimdo.com', '1118282421', '6');
insert into [dbo].[Donors] ([DonorId], [DonorFirstName], [DonorLastName], [DonorBirthday], [DonorAddress], [DonorPhone], [BloodTypeId]) values (3, 'Kakalina', 'Hursey', '10/28/2000', 'khursey2@paginegialle.it', '5119179333', '8');
insert into [dbo].[Donors] ([DonorId], [DonorFirstName], [DonorLastName], [DonorBirthday], [DonorAddress], [DonorPhone], [BloodTypeId]) values (4, 'Bunni', 'McDill', '08/10/1980', 'bmcdill3@posterous.com', '5901915767', '5');
insert into [dbo].[Donors] ([DonorId], [DonorFirstName], [DonorLastName], [DonorBirthday], [DonorAddress], [DonorPhone], [BloodTypeId]) values (5, 'Borg', 'Syversen', '07/27/1976', 'bsyversen4@nbcnews.com', '2248017959', '7');
insert into [dbo].[Donors] ([DonorId], [DonorFirstName], [DonorLastName], [DonorBirthday], [DonorAddress], [DonorPhone], [BloodTypeId]) values (6, 'Geralda', 'Kardos', '03/18/1957', 'gkardos5@nhs.uk', '4486781860', '8');
insert into [dbo].[Donors] ([DonorId], [DonorFirstName], [DonorLastName], [DonorBirthday], [DonorAddress], [DonorPhone], [BloodTypeId]) values (7, 'Meredithe', 'Vye', '02/03/1969', 'mvye6@cdbaby.com', '4382975712', '8');
insert into [dbo].[Donors] ([DonorId], [DonorFirstName], [DonorLastName], [DonorBirthday], [DonorAddress], [DonorPhone], [BloodTypeId]) values (8, 'Northrup', 'Dudley', '06/24/1961', 'ndudley7@qq.com', '1828812496', '8');
insert into [dbo].[Donors] ([DonorId], [DonorFirstName], [DonorLastName], [DonorBirthday], [DonorAddress], [DonorPhone], [BloodTypeId]) values (9, 'Malynda', 'Coram', '08/22/1983', 'mcoram8@biglobe.ne.jp', '2825008266', '6');
insert into [dbo].[Donors] ([DonorId], [DonorFirstName], [DonorLastName], [DonorBirthday], [DonorAddress], [DonorPhone], [BloodTypeId]) values (10, 'Jewell', 'de Clerc', '03/02/1982', 'jdeclerc9@slate.com', '6851611904', '7');

GO
INSERT INTO [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName]) VALUES (1, 'Damara', 'Tayler');
INSERT INTO [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName]) VALUES (2, 'Evangelin', 'Sprigin');
INSERT INTO [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName]) VALUES (3, 'Johan', 'Cottham');
INSERT INTO [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName]) VALUES (4, 'Vlad', 'Fiennes');
INSERT INTO [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName]) VALUES (5, 'Brody', 'Macallam');
INSERT INTO [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName]) VALUES (6, 'Kippy', 'Mitchelson');
INSERT INTO [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName]) VALUES (7, 'Whitby', 'Staterfield');
INSERT INTO [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName]) VALUES (8, 'Lauren', 'Burdge');
INSERT INTO [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName]) VALUES (9, 'Vic', 'Dyhouse');
INSERT INTO [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName]) VALUES (10, 'Harp', 'Gainforth');

GO


INSERT INTO [dbo].[BloodDeposit] ([UnitId], [UnitPrice], [UnitExpiryDate], [BloodTypeId]) VALUES (1, '573.40', '01/19/2021', '8');
INSERT INTO [dbo].[BloodDeposit] ([UnitId], [UnitPrice], [UnitExpiryDate], [BloodTypeId]) VALUES (2, '353.46', '09/12/2021', '7');
INSERT INTO [dbo].[BloodDeposit] ([UnitId], [UnitPrice], [UnitExpiryDate], [BloodTypeId]) VALUES (3, '642.74', '04/27/2021', '8');
INSERT INTO [dbo].[BloodDeposit] ([UnitId], [UnitPrice], [UnitExpiryDate], [BloodTypeId]) VALUES (4, '585.60', '01/14/2021', '8');
INSERT INTO [dbo].[BloodDeposit] ([UnitId], [UnitPrice], [UnitExpiryDate], [BloodTypeId]) VALUES (5, '421.33', '03/30/2021', '7');
INSERT INTO [dbo].[BloodDeposit] ([UnitId], [UnitPrice], [UnitExpiryDate], [BloodTypeId]) VALUES (6, '484.60', '01/11/2021', '8');
INSERT INTO [dbo].[BloodDeposit] ([UnitId], [UnitPrice], [UnitExpiryDate], [BloodTypeId]) VALUES (7, '605.59', '06/13/2021', '6');
INSERT INTO [dbo].[BloodDeposit] ([UnitId], [UnitPrice], [UnitExpiryDate], [BloodTypeId]) VALUES (8, '636.18', '01/17/2021', '8');
INSERT INTO [dbo].[BloodDeposit] ([UnitId], [UnitPrice], [UnitExpiryDate], [BloodTypeId]) VALUES (9, '567.36', '04/28/2021', '8');
INSERT INTO [dbo].[BloodDeposit] ([UnitId], [UnitPrice], [UnitExpiryDate], [BloodTypeId]) VALUES (10, '331.01', '07/23/2021', '8');
INSERT INTO [dbo].[BloodDeposit] ([UnitId], [UnitPrice], [UnitExpiryDate], [BloodTypeId]) VALUES (11, '519.54', '08/15/2021', '6');

GO




INSERT INTO [dbo].[BloodWithdrawals] ([BloodWithdrawalId], [BloodWithdrawalDate], [TransactionValue], [UnitQuantity], [ClientId]) VALUES (1, '12/23/2019', '892.00', 2, '4');
INSERT INTO [dbo].[BloodWithdrawals] ([BloodWithdrawalId], [BloodWithdrawalDate], [TransactionValue], [UnitQuantity], [ClientId]) VALUES (2, '3/21/2020', '794.60', 2, '3');
INSERT INTO [dbo].[BloodWithdrawals] ([BloodWithdrawalId], [BloodWithdrawalDate], [TransactionValue], [UnitQuantity], [ClientId]) VALUES (3, '4/22/2020', '805.85', 1, '9');
INSERT INTO [dbo].[BloodWithdrawals] ([BloodWithdrawalId], [BloodWithdrawalDate], [TransactionValue], [UnitQuantity], [ClientId]) VALUES (4, '9/23/2020', '989.01', 1, '10');
INSERT INTO [dbo].[BloodWithdrawals] ([BloodWithdrawalId], [BloodWithdrawalDate], [TransactionValue], [UnitQuantity], [ClientId]) VALUES (5, '7/23/2020', '359.73', 2, '2');
INSERT INTO [dbo].[BloodWithdrawals] ([BloodWithdrawalId], [BloodWithdrawalDate], [TransactionValue], [UnitQuantity], [ClientId]) VALUES (6, '6/8/2020', '421.19', 1, '1');
INSERT INTO [dbo].[BloodWithdrawals] ([BloodWithdrawalId], [BloodWithdrawalDate], [TransactionValue], [UnitQuantity], [ClientId]) VALUES (7, '4/19/2020', '692.95', 2, '5');
INSERT INTO [dbo].[BloodWithdrawals] ([BloodWithdrawalId], [BloodWithdrawalDate], [TransactionValue], [UnitQuantity], [ClientId]) VALUES (8, '1/6/2020', '432.94', 2, '4');
INSERT INTO [dbo].[BloodWithdrawals] ([BloodWithdrawalId], [BloodWithdrawalDate], [TransactionValue], [UnitQuantity], [ClientId]) VALUES (9, '2/23/2020', '954.70', 2, '8');
INSERT INTO [dbo].[BloodWithdrawals] ([BloodWithdrawalId], [BloodWithdrawalDate], [TransactionValue], [UnitQuantity], [ClientId]) VALUES (10, '5/13/2020', '591.96', 1, '4');

GO


INSERT INTO [dbo].[Donations] ([DonationId], [DonationBloodVolume], [MedicalReport], [BloodTypeId], [DonorId], [DonationDate]) VALUES (1, 964, 'tincidunt', '7', '3', '08/01/2021');
INSERT INTO [dbo].[Donations] ([DonationId], [DonationBloodVolume], [MedicalReport], [BloodTypeId], [DonorId], [DonationDate]) VALUES (2, 460, 'sodales scelerisque mauris sit amet eros suspendisse', '5', '4', '09/21/2021');
INSERT INTO [dbo].[Donations] ([DonationId], [DonationBloodVolume], [MedicalReport], [BloodTypeId], [DonorId], [DonationDate]) VALUES (3, 659, 'quis orci nullam molestie nibh in lectus', '8', '5', '12/05/2020');
INSERT INTO [dbo].[Donations] ([DonationId], [DonationBloodVolume], [MedicalReport], [BloodTypeId], [DonorId], [DonationDate]) VALUES (4, 940, 'sapien quis libero nullam sit amet', '7', '7', '11/04/2021');
INSERT INTO [dbo].[Donations] ([DonationId], [DonationBloodVolume], [MedicalReport], [BloodTypeId], [DonorId], [DonationDate]) VALUES (5, 795, 'rutrum', '8', '8', '05/21/2021');
INSERT INTO [dbo].[Donations] ([DonationId], [DonationBloodVolume], [MedicalReport], [BloodTypeId], [DonorId], [DonationDate]) VALUES (6, 548, '', '8', '10', '10/17/2021');
INSERT INTO [dbo].[Donations] ([DonationId], [DonationBloodVolume], [MedicalReport], [BloodTypeId], [DonorId], [DonationDate]) VALUES (7, 792, 'amet sem fusce consequat', '8', '7', '10/16/2021');
INSERT INTO [dbo].[Donations] ([DonationId], [DonationBloodVolume], [MedicalReport], [BloodTypeId], [DonorId], [DonationDate]) VALUES (8, 450, '', '7', '7', '08/05/2021');
INSERT INTO [dbo].[Donations] ([DonationId], [DonationBloodVolume], [MedicalReport], [BloodTypeId], [DonorId], [DonationDate]) VALUES (9, 456, 'nec dui luctus rutrum nulla', '8', '6', '12/21/2020');
INSERT INTO [dbo].[Donations] ([DonationId], [DonationBloodVolume], [MedicalReport], [BloodTypeId], [DonorId], [DonationDate]) VALUES (10, 684, 'suscipit nulla elit ac nulla sed vel', '7', '5', '08/27/2021');
GO


INSERT INTO [dbo].[BloodWithdrawalUnits] ([BloodWithdrawalUnitsId], [UnitId], [BloodWithdrawalId]) VALUES (1, '1', '1');
INSERT INTO [dbo].[BloodWithdrawalUnits] ([BloodWithdrawalUnitsId], [UnitId], [BloodWithdrawalId]) VALUES (2, '4', '2');
INSERT INTO [dbo].[BloodWithdrawalUnits] ([BloodWithdrawalUnitsId], [UnitId], [BloodWithdrawalId]) VALUES (3, '3', '3');
INSERT INTO [dbo].[BloodWithdrawalUnits] ([BloodWithdrawalUnitsId], [UnitId], [BloodWithdrawalId]) VALUES (4, '2', '4');
INSERT INTO [dbo].[BloodWithdrawalUnits] ([BloodWithdrawalUnitsId], [UnitId], [BloodWithdrawalId]) VALUES (5, '7', '5');
INSERT INTO [dbo].[BloodWithdrawalUnits] ([BloodWithdrawalUnitsId], [UnitId], [BloodWithdrawalId]) VALUES (6, '3', '6');
INSERT INTO [dbo].[BloodWithdrawalUnits] ([BloodWithdrawalUnitsId], [UnitId], [BloodWithdrawalId]) VALUES (7, '7', '7');
INSERT INTO [dbo].[BloodWithdrawalUnits] ([BloodWithdrawalUnitsId], [UnitId], [BloodWithdrawalId]) VALUES (8, '8', '8');
INSERT INTO [dbo].[BloodWithdrawalUnits] ([BloodWithdrawalUnitsId], [UnitId], [BloodWithdrawalId]) VALUES (9, '9', '9');
INSERT INTO [dbo].[BloodWithdrawalUnits] ([BloodWithdrawalUnitsId], [UnitId], [BloodWithdrawalId]) VALUES (10, '10', '10');

GO