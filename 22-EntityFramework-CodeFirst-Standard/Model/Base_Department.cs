namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Department
    {
        [StringLength(40)]
        public string ID { get; set; }

        [StringLength(40)]
        public string PARENT_ID { get; set; }

        [StringLength(50)]
        public string PARENT_NAME { get; set; }

        [StringLength(50)]
        public string PARENT_CODE { get; set; }

        [StringLength(8)]
        public string COMPANY_ID { get; set; }

        [StringLength(50)]
        public string COMPANY_NAME { get; set; }

        [StringLength(50)]
        public string COMPANY_CODE { get; set; }

        [StringLength(40)]
        public string MANAGER_ID { get; set; }

        [StringLength(50)]
        public string MANAGER { get; set; }

        [StringLength(50)]
        public string MANAGER_MOBILE { get; set; }

        [StringLength(50)]
        public string MANAGER_QQ { get; set; }

        [StringLength(30)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string SHORT_NAME { get; set; }

        [Required]
        [StringLength(200)]
        public string FULL_NAME { get; set; }

        [StringLength(50)]
        public string CATEGORY_CODE { get; set; }

        [StringLength(50)]
        public string CATEGORY_NAME { get; set; }

        [StringLength(200)]
        public string OUTER_PHONE { get; set; }

        [StringLength(200)]
        public string INNER_PHONE { get; set; }

        [StringLength(50)]
        public string FAX { get; set; }

        public int? DELETION_STATE_CODE { get; set; }

        public int? ENABLED { get; set; }

        public int? SORT_CODE { get; set; }

        [StringLength(1000)]
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

        public int? IS_VISIBLE { get; set; }
    }
}
