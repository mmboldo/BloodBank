namespace BloodBankCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Donor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Donor()
        {
            Donations = new HashSet<Donation>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DonorId { get; set; }

        [Required]
        [StringLength(50)]
        public string DonorFirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string DonorLastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime DonorBirthday { get; set; }

        [Required]
        [StringLength(50)]
        public string DonorAddress { get; set; }

        [Required]
        [StringLength(10)]
        public string DonorPhone { get; set; }

        public int BloodTypeId { get; set; }

        public virtual BloodType BloodType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Donation> Donations { get; set; }
    }
}
