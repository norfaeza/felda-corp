namespace MVC_SYSTEM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblEmailList")]
    public partial class tblEmailList
    {
        [Key]
        public int fldID { get; set; }

        [StringLength(50)]
        public string fldEmail { get; set; }

        [StringLength(100)]
        public string fldName { get; set; }

        [Required]
        public string fldCategory { get; set; }

        [Required]
        [StringLength(30)]
        public string fldDepartment { get; set; }

        public bool? fldDeleted { get; set; }

        public int? fldNegaraID { get; set; }

        public int? fldSyarikatID { get; set; }

        public int? fldWilayahID { get; set; }

        public int? fldLadangID { get; set; }    }

}
