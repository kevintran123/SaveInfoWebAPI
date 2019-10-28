namespace SaveInfo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Agent")]
    public partial class Agent
    {
        [Key]
        public int RecordID { get; set; }

        [StringLength(20)]
        public string AgentID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(150)]
        public string FullName { get; set; }

        public short? TaxType { get; set; }

        [StringLength(11)]
        public string TaxId { get; set; }

        [Column(TypeName = "ntext")]
        public string BusinessStreet { get; set; }

        [StringLength(50)]
        public string BusinessCity { get; set; }

        [StringLength(2)]
        public string BusinessState { get; set; }

        [StringLength(10)]
        public string BusinessZipCode { get; set; }

        [StringLength(50)]
        public string BusinessPhone { get; set; }

        [StringLength(50)]
        public string BusinessFax { get; set; }

        [StringLength(50)]
        public string BusinessMobile { get; set; }

        [StringLength(50)]
        public string BusinessPager { get; set; }

        [StringLength(50)]
        public string BusinessEMail { get; set; }

        [Column(TypeName = "ntext")]
        public string BusinessAddress { get; set; }

        [Column(TypeName = "ntext")]
        public string HomeStreet { get; set; }

        [StringLength(50)]
        public string HomeCity { get; set; }

        [StringLength(2)]
        public string HomeState { get; set; }

        [StringLength(10)]
        public string HomeZipCode { get; set; }

        public bool MailToHome { get; set; }

        [StringLength(50)]
        public string HomePhone { get; set; }

        [StringLength(50)]
        public string HomeFax { get; set; }

        [StringLength(50)]
        public string HomeMobile { get; set; }

        [StringLength(50)]
        public string HomeEMail { get; set; }

        [Column(TypeName = "ntext")]
        public string HomeAddress { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}
