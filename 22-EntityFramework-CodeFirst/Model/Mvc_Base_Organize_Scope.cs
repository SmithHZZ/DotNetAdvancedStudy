namespace _22_EntityFramework_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mvc_Base_Organize_Scope
    {
        [StringLength(40)]
        public string ID { get; set; }

        [StringLength(40)]
        public string RESOURCE_CATEGORY { get; set; }

        [StringLength(40)]
        public string RESOURCE_ID { get; set; }

        [StringLength(40)]
        public string PERMISSION_ID { get; set; }

        public int? ALL_DATA { get; set; }

        public int USER_COMPANY { get; set; }

        public int? USER_SUB_COMPANY { get; set; }

        public int? USER_DEPARTMENT { get; set; }

        public int? USER_SUB_DEPARTMENT { get; set; }

        public int? USER_WORKGROUP { get; set; }

        public int? ONLY_OWN_DATA { get; set; }

        public int? NOT_ALLOWED { get; set; }

        public int? BY_DETAILS { get; set; }

        public int? CONTAIN_CHILD { get; set; }

        public int? ENABLED { get; set; }

        public int? DELETION_STATE_CODE { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public DateTime CREATE_ON { get; set; }

        [StringLength(40)]
        public string CREATE_USER_ID { get; set; }

        [StringLength(20)]
        public string CREATE_BY { get; set; }

        public DateTime? MODIFIED_ON { get; set; }

        [StringLength(40)]
        public string MODIFIED_USER_ID { get; set; }

        [StringLength(20)]
        public string MODIFIED_BY { get; set; }

        public int? PROVINCE { get; set; }

        public int? CITY { get; set; }

        public int? DISTRICT { get; set; }

        public int? STREET { get; set; }
    }
}
