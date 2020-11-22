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
        }
    }
}
