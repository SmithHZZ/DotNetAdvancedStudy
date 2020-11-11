namespace _22_EntityFramework_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Message
    {
        [StringLength(40)]
        public string ID { get; set; }

        [StringLength(40)]
        public string PARENT_ID { get; set; }

        [StringLength(40)]
        public string RECEIVER_DEPARTMENT_ID { get; set; }

        [StringLength(50)]
        public string RECEIVER_DEPARTMENT_NAME { get; set; }

        [StringLength(40)]
        public string RECEIVER_ID { get; set; }

        [StringLength(50)]
        public string RECEIVER_REAL_NAME { get; set; }

        [StringLength(50)]
        public string CATEGORY_CODE { get; set; }

        [StringLength(50)]
        public string FUNCTION_CODE { get; set; }

        [StringLength(40)]
        public string OBJECT_ID { get; set; }

        [StringLength(100)]
        public string TITLE { get; set; }

        [StringLength(800)]
        public string CONTENTS { get; set; }

        public int? IS_NEW { get; set; }

        public int READ_COUNT { get; set; }

        public DateTime? READ_DATE { get; set; }

        [StringLength(400)]
        public string TARGET_URL { get; set; }

        [StringLength(50)]
        public string IPADDRESS { get; set; }

        [StringLength(50)]
        public string QQ { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string TELEPHONE { get; set; }

        [StringLength(50)]
        public string CREATE_DEPARTMENT_ID { get; set; }

        [StringLength(50)]
        public string CREATE_DEPARTMENT_NAME { get; set; }

        public int? DELETION_STATE_CODE { get; set; }

        public int ENABLED { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public int? SORT_CODE { get; set; }

        public DateTime? CREATE_ON { get; set; }

        [StringLength(40)]
        public string CREATE_USER_ID { get; set; }

        [StringLength(50)]
        public string CREATE_BY { get; set; }

        [StringLength(50)]
        public string MODIFIED_BY { get; set; }

        [StringLength(40)]
        public string MODIFIED_USER_ID { get; set; }

        public DateTime? MODIFIED_ON { get; set; }

        [StringLength(8)]
        public string CREATE_COMPANY_ID { get; set; }

        [StringLength(50)]
        public string CREATE_COMPANY_NAME { get; set; }
    }
}
