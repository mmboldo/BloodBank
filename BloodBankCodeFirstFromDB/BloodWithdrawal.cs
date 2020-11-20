namespace BloodBankCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BloodWithdrawal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BloodWithdrawal()
        {
            BloodWithdrawalUnits = new HashSet<BloodWithdrawalUnit>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BloodWithdrawalId { get; set; }

        public DateTime BloodWithdrawalDate { get; set; }

        public float TransactionValue { get; set; }

        public int UnitQuantity { get; set; }

        public int ClientId { get; set; }

        public virtual Client Client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BloodWithdrawalUnit> BloodWithdrawalUnits { get; set; }
    }
}
