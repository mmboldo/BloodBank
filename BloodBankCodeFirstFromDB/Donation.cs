namespace BloodBankCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Donation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DonationId { get; set; }

        public float DonationBloodVolume { get; set; }

        [Required]
        [StringLength(100)]
        public string MedicalReport { get; set; }

        public int BloodTypeId { get; set; }

        public int DonorId { get; set; }

        public DateTime DonationDate { get; set; }

        public virtual BloodType BloodType { get; set; }

        public virtual Donor Donor { get; set; }
    }
}
