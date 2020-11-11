namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Staff_Organize
    {
        [StringLength(40)]
        public string ID { get; set; }

        [StringLength(40)]
        public string STAFF_ID { get; set; }

        [Required]
        [StringLength(8)]
        public string ORGANIZE_ID { get; set; }

        public int? DELETION_STATE_CODE { get; set; }

        public int ENABLED { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public DateTime? CREATE_ON { get; set; }

        [StringLength(40)]
        public string CREATE_USER_ID { get; set; }

        [StringLength(50)]
        public string CREATE_BY { get; set; }

        public DateTime? MODIFIED_ON { get; set; }

        [StringLength(40)]
        public string MODIFIED_USER_ID { get; set; }

        [StringLength(50)]
        public string MODIFIED_BY { get; set; }
    }
}
