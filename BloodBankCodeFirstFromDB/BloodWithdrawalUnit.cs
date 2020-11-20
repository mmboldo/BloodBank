namespace BloodBankCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BloodWithdrawalUnit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BloodWithdrawalUnitsId { get; set; }

        public int UnitId { get; set; }

        public int BloodWithdrawalId { get; set; }

        public virtual BloodDeposit BloodDeposit { get; set; }

        public virtual BloodWithdrawal BloodWithdrawal { get; set; }
    }
}
