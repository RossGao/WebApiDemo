namespace ProductsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FAIRMANAGER.SO_EMPLOYEESSOCIAL")]
    public partial class SO_EMPLOYEESSOCIAL
    {
        [Key]
        [StringLength(32)]
        public string PKID { get; set; }

        [StringLength(32)]
        public string EMPLOYEEID { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public decimal? STATE { get; set; }

        [StringLength(50)]
        public string SSCOMPUTENO { get; set; }

        [StringLength(18)]
        public string MANCARD { get; set; }

        [StringLength(20)]
        public string SSCARD { get; set; }

        [StringLength(50)]
        public string SSCOMPANY { get; set; }

        [StringLength(20)]
        public string GJCARD { get; set; }

        public decimal? PAYFEES { get; set; }

        [StringLength(50)]
        public string SSTYPE { get; set; }

        public decimal? AREAID { get; set; }

        [StringLength(50)]
        public string JOINCITY { get; set; }

        [StringLength(14)]
        public string BACKTIME { get; set; }

        public decimal? OPERATETYPE { get; set; }

        [StringLength(32)]
        public string ADDUSERID { get; set; }

        [StringLength(32)]
        public string UPDATEUSERID { get; set; }

        public decimal? ISDELETE { get; set; }

        public DateTime? ADDTIME { get; set; }

        public DateTime? UPDATETIME { get; set; }

        public decimal? ISACTIVE { get; set; }

        public decimal? ISSSTYPE { get; set; }

        public decimal? ISCHECKED { get; set; }

        public decimal? ISINHISTORY { get; set; }
    }
}
