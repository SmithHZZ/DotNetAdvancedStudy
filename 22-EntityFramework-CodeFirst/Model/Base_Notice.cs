namespace _22_EntityFramework_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Notice
    {
        [StringLength(40)]
        public string ID { get; set; }

        [StringLength(50)]
        public string CATEGORY_CODE { get; set; }

        [StringLength(40)]
        public string PARAMETER_ID { get; set; }

        [StringLength(50)]
        public string PARAMETER_CODE { get; set; }

        [StringLength(2000)]
        public string PARAMETER_CONTENT { get; set; }

        public int WORKED { get; set; }

        public int ENABLED { get; set; }

        public int? DELETION_STATE_CODE { get; set; }

        public int? SORT_CODE { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        [StringLength(40)]
        public string CREATE_USER_ID { get; set; }

        [StringLength(50)]
        public string CREATE_BY { get; set; }

        public DateTime? CREATE_ON { get; set; }

        public DateTime? MODIFIED_ON { get; set; }

        [StringLength(40)]
        public string MODIFIED_USER_ID { get; set; }

        [StringLength(50)]
        public string MODIFIED_BY { get; set; }
    }
}
