using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBankCodeFirstFromDB;

namespace SeedDatabaseExtensions
{
    public static class SeedDatabaseExtensionMethods
    {
        public static void SeedDatabase(this BloodBankEntities context)
        {
            context.Database.Log = (s => Debug.Write(s));
			context.Database.Delete();
			context.Database.Create();

			context.SaveChanges();
            context.BloodDeposits.Load();
            context.BloodTypes.Load();
            context.BloodWithdrawals.Load();
            context.BloodWithdrawalUnits.Load();
            context.Clients.Load();
            context.Donations.Load();
            context.Donors.Load();

            List<BloodType> bloodTypesList = new List<BloodType>
            {
                new BloodType{BloodTypeId = 1, BloodType1 = "A+", PricePerUnit = 150.00f },
                new BloodType{BloodTypeId = 2, BloodType1 = "A-", PricePerUnit = 300.00f },
                new BloodType{BloodTypeId = 3, BloodType1 = "B+", PricePerUnit = 300.00f },
                new BloodType{BloodTypeId = 4, BloodType1 = "B-", PricePerUnit = 400.00f },
                new BloodType{BloodTypeId = 5, BloodType1 = "AB+", PricePerUnit = 400.00f },
                new BloodType{BloodTypeId = 6, BloodType1 = "AB-", PricePerUnit = 500.00f },
                new BloodType{BloodTypeId = 7, BloodType1 = "O+", PricePerUnit = 150.00f },
                new BloodType{BloodTypeId = 8, BloodType1 = "O-", PricePerUnit = 400.00f },

            };
            Dictionary<int, BloodType> bloodTypes = bloodTypesList.ToDictionary(x => x.BloodTypeId, x => x);
            context.BloodTypes.AddRange(bloodTypesList);
            context.SaveChanges();

            List<Donor> donorList = new List<Donor>
            {
                new Donor{DonorId = 1, DonorFirstName = "Pierre", DonorLastName = "Lovelady", DonorBirthday = new DateTime(1994, 9, 13), DonorAddress = "plovelady0@vkontakte.ru", DonorPhone = "4105654504", BloodTypeId = 1, BloodType = bloodTypes[1]},
                new Donor{DonorId = 2, DonorFirstName = "Winnifred", DonorLastName = "Halbeard", DonorBirthday = new DateTime(1980, 3, 14), DonorAddress = "whalbeard1@jimdo.com", DonorPhone = "1118282421", BloodTypeId = 3, BloodType = bloodTypes[3]},
                new Donor{DonorId = 3, DonorFirstName = "Kaklina", DonorLastName = "Hursey", DonorBirthday = new DateTime(2000, 4, 25), DonorAddress = "khursey2@paginegialle.it", DonorPhone = "5119179333", BloodTypeId = 4, BloodType = bloodTypes[4]},
                new Donor{DonorId = 4, DonorFirstName = "Bunni", DonorLastName = "McDill", DonorBirthday = new DateTime(1980, 7, 4), DonorAddress = "bmcdill3@posterous.com", DonorPhone = "5901915767", BloodTypeId = 6, BloodType = bloodTypes[6]},
                new Donor{DonorId = 5, DonorFirstName = "Borg", DonorLastName = "Syversen", DonorBirthday = new DateTime(1976, 1, 17), DonorAddress = "bsyversen4@nbcnews.com", DonorPhone = "2248017959", BloodTypeId = 4, BloodType = bloodTypes[4]},
                new Donor{DonorId = 6, DonorFirstName = "Geralda", DonorLastName = "Kardos", DonorBirthday = new DateTime(1957, 8, 31), DonorAddress = "gkardos5@nhs.uk", DonorPhone = "4486781860", BloodTypeId = 5, BloodType = bloodTypes[5]},
                new Donor{DonorId = 7, DonorFirstName = "Meredithe", DonorLastName = "Vye", DonorBirthday = new DateTime(1969, 12, 30), DonorAddress = "mvye6@cdbaby.com", DonorPhone = "4382975712", BloodTypeId = 2, BloodType = bloodTypes[2]},
                new Donor{DonorId = 8, DonorFirstName = "Jean-Luc", DonorLastName = "Picard", DonorBirthday = new DateTime(1961, 5, 25), DonorAddress = "JLPicard@earth.fed", DonorPhone = "1828812496", BloodTypeId = 3, BloodType = bloodTypes[3]},
                new Donor{DonorId = 9, DonorFirstName = "Malynda", DonorLastName = "Coram", DonorBirthday = new DateTime(1983, 3, 11), DonorAddress = "mcoram8@biglobe.ne.jp", DonorPhone = "2825008266", BloodTypeId = 1, BloodType = bloodTypes[1]},
                new Donor{DonorId = 10, DonorFirstName = "Darth", DonorLastName = "Vader", DonorBirthday = new DateTime(1982, 2, 3), DonorAddress = "DVader@empire.gal", DonorPhone = "6851611904", BloodTypeId = 8, BloodType = bloodTypes[8]},


            };
            Dictionary<int, Donor> donors = donorList.ToDictionary(x => x.DonorId, x => x);
            context.Donors.AddRange(donorList);
            context.SaveChanges();
            List<Client> clientList = new List<Client>
            {
                new Client{ClientId = 1, ClientFirstName = "Damara", ClientLastName = "Tayler"},
                new Client{ClientId = 2, ClientFirstName = "Evangelin", ClientLastName = "Sprigin"},
                new Client{ClientId = 3, ClientFirstName = "Johan", ClientLastName = "Cottham"},
                new Client{ClientId = 4, ClientFirstName = "Vlad", ClientLastName = "der Impalen"},
                new Client{ClientId = 5, ClientFirstName = "Brody", ClientLastName = "Fiennes"},
                new Client{ClientId = 6, ClientFirstName = "Kippy", ClientLastName = "Macallam"},
                new Client{ClientId = 7, ClientFirstName = "Whitby", ClientLastName = "Mitchelson"},
                new Client{ClientId = 8, ClientFirstName = "Lauren", ClientLastName = "Staterfield"},
                new Client{ClientId = 9, ClientFirstName = "Vic", ClientLastName = "Burdge"},
                new Client{ClientId = 10, ClientFirstName = "Harp", ClientLastName = "Gainforth"},



            };
            Dictionary<int, Client> clients = clientList.ToDictionary(x => x.ClientId, x => x);
            context.Clients.AddRange(clientList);
            context.SaveChanges();
            List<BloodDeposit> bloodDepositList = new List<BloodDeposit>
            {
                new BloodDeposit{UnitId = 1, UnitPrice = Decimal.Parse(bloodTypes[1].PricePerUnit.ToString()) ,UnitExpiryDate = new DateTime(2021, 1, 19) , BloodTypeId = 1, BloodType = bloodTypes[1] },
                new BloodDeposit{UnitId = 2, UnitPrice = Decimal.Parse(bloodTypes[3].PricePerUnit.ToString()) ,UnitExpiryDate = new DateTime(2021, 3, 5) , BloodTypeId = 3, BloodType = bloodTypes[3] },
                new BloodDeposit{UnitId = 3, UnitPrice = Decimal.Parse(bloodTypes[5].PricePerUnit.ToString()) ,UnitExpiryDate = new DateTime(2021, 5, 13) , BloodTypeId = 5, BloodType = bloodTypes[5] },
                new BloodDeposit{UnitId = 4, UnitPrice = Decimal.Parse(bloodTypes[4].PricePerUnit.ToString()) ,UnitExpiryDate = new DateTime(2021, 2, 14) , BloodTypeId = 4, BloodType = bloodTypes[4] },
                new BloodDeposit{UnitId = 5, UnitPrice = Decimal.Parse(bloodTypes[6].PricePerUnit.ToString()) ,UnitExpiryDate = new DateTime(2021, 8, 31) , BloodTypeId = 6, BloodType = bloodTypes[6] },
                new BloodDeposit{UnitId = 6, UnitPrice = Decimal.Parse(bloodTypes[7].PricePerUnit.ToString()) ,UnitExpiryDate = new DateTime(2021, 5, 17) , BloodTypeId = 7, BloodType = bloodTypes[7] },
                new BloodDeposit{UnitId = 7, UnitPrice = Decimal.Parse(bloodTypes[2].PricePerUnit.ToString()) ,UnitExpiryDate = new DateTime(2021, 4, 29) , BloodTypeId = 2, BloodType = bloodTypes[2] },
                new BloodDeposit{UnitId = 8, UnitPrice = Decimal.Parse(bloodTypes[8].PricePerUnit.ToString()) ,UnitExpiryDate = new DateTime(2021, 2, 9) , BloodTypeId = 8, BloodType = bloodTypes[8] },
                new BloodDeposit{UnitId = 9, UnitPrice = Decimal.Parse(bloodTypes[6].PricePerUnit.ToString()) ,UnitExpiryDate = new DateTime(2021, 7, 1) , BloodTypeId = 6, BloodType = bloodTypes[6] },
                new BloodDeposit{UnitId = 10, UnitPrice = Decimal.Parse(bloodTypes[2].PricePerUnit.ToString()) ,UnitExpiryDate = new DateTime(2021, 12, 13) , BloodTypeId = 2, BloodType = bloodTypes[2] },
            };
            Dictionary<int, BloodDeposit> bloodDeposits = bloodDepositList.ToDictionary(x => x.UnitId, x => x);
            context.BloodDeposits.AddRange(bloodDepositList);
            context.SaveChanges();

            List<BloodWithdrawal> bloodWithdrawalList = new List<BloodWithdrawal>
            {
                new BloodWithdrawal{BloodWithdrawalId = 1, BloodWithdrawalDate = new DateTime(2019,12,23), TransactionValue = 300.00f, UnitQuantity = 1, ClientId = 1 },
                new BloodWithdrawal{BloodWithdrawalId = 2, BloodWithdrawalDate = new DateTime(2020,2,23), TransactionValue = 450.00f, UnitQuantity = 1, ClientId = 3 },
                new BloodWithdrawal{BloodWithdrawalId = 3, BloodWithdrawalDate = new DateTime(2018,3,13), TransactionValue = 500.00f, UnitQuantity = 1, ClientId = 6 },
                new BloodWithdrawal{BloodWithdrawalId = 4, BloodWithdrawalDate = new DateTime(2020,6,4), TransactionValue = 400.00f, UnitQuantity = 1, ClientId = 4},
                new BloodWithdrawal{BloodWithdrawalId = 5, BloodWithdrawalDate = new DateTime(2018,4,22), TransactionValue = 800.00f, UnitQuantity = 2, ClientId = 2 },
            };
            Dictionary<int, BloodWithdrawal> bloodWithdrawals = bloodWithdrawalList.ToDictionary(x => x.BloodWithdrawalId, x => x);
            context.BloodWithdrawals.AddRange(bloodWithdrawalList);
            context.SaveChanges();

            
            List<Donation> donationsList = new List<Donation>
            {
                new Donation{DonationId = 1, DonationBloodVolume = 1, MedicalReport = "has Diabetes",BloodTypeId = donors[1].BloodTypeId, DonorId= 1, DonationDate = new DateTime(2019,3,21) },
                new Donation{DonationId = 2, DonationBloodVolume = 1, MedicalReport = "flu like symptoms",BloodTypeId = donors[2].BloodTypeId, DonorId= 2, DonationDate = new DateTime(2020,4,3) },
                new Donation{DonationId = 3, DonationBloodVolume = 1, MedicalReport = "COVID-19 Symptoms",BloodTypeId = donors[3].BloodTypeId, DonorId= 3, DonationDate = new DateTime(2019,12,5) },
                new Donation{DonationId = 4, DonationBloodVolume = 1, MedicalReport = "healthy",BloodTypeId = donors[4].BloodTypeId, DonorId= 4, DonationDate = new DateTime(2020, 10, 31) },
                new Donation{DonationId = 5, DonationBloodVolume = 1, MedicalReport = "traveled to Russia",BloodTypeId = donors[5].BloodTypeId, DonorId= 5, DonationDate = new DateTime(2020,11,21) },
                new Donation{DonationId = 6, DonationBloodVolume = 1, MedicalReport = "recently infected with Pneumonia",BloodTypeId = donors[6].BloodTypeId, DonorId= 1, DonationDate = new DateTime(2020,5,1) },
                new Donation{DonationId = 7, DonationBloodVolume = 1, MedicalReport = "traveled to USA",BloodTypeId = donors[7].BloodTypeId, DonorId= 7, DonationDate = new DateTime(2020,10,24) },
                new Donation{DonationId = 8, DonationBloodVolume = 1, MedicalReport = "slight cough",BloodTypeId = donors[8].BloodTypeId, DonorId= 8, DonationDate = new DateTime(2020,7,1) },
                new Donation{DonationId = 9, DonationBloodVolume = 1, MedicalReport = "fever",BloodTypeId = donors[9].BloodTypeId, DonorId= 9, DonationDate = new DateTime(2020,9,25) },
                new Donation{DonationId = 10, DonationBloodVolume = 1, MedicalReport = "clinically dead",BloodTypeId = donors[10].BloodTypeId, DonorId= 10, DonationDate = new DateTime(2020,8,12) },
            };
            Dictionary<int, Donation> donations = donationsList.ToDictionary(x => x.DonationId, x => x);
            context.Donations.AddRange(donationsList);
            context.SaveChanges();

            List<BloodWithdrawalUnit> bloodWithdrawalUnitsList = new List<BloodWithdrawalUnit>
            {
                new BloodWithdrawalUnit{BloodWithdrawalUnitsId = 1, UnitId = 1, BloodWithdrawalId= 1},
                new BloodWithdrawalUnit{BloodWithdrawalUnitsId = 2, UnitId = 2, BloodWithdrawalId= 2},
                new BloodWithdrawalUnit{BloodWithdrawalUnitsId = 3, UnitId = 3, BloodWithdrawalId= 3},
                new BloodWithdrawalUnit{BloodWithdrawalUnitsId = 4, UnitId = 4, BloodWithdrawalId= 4},
                new BloodWithdrawalUnit{BloodWithdrawalUnitsId = 5, UnitId = 5, BloodWithdrawalId= 5},
            };
            Dictionary<int, BloodWithdrawalUnit> bloodWithdrawalUnits = bloodWithdrawalUnitsList.ToDictionary(x => x.BloodWithdrawalUnitsId, x => x);
            context.BloodWithdrawalUnits.AddRange(bloodWithdrawalUnitsList);
            context.SaveChanges();

        }
    }
}
