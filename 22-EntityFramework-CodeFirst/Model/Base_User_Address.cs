namespace _22_EntityFramework_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_User_Address
    {
        [StringLength(40)]
        public string ID { get; set; }

        [StringLength(40)]
        public string USER_ID { get; set; }

        [StringLength(30)]
        public string REAL_NAME { get; set; }

        [StringLength(40)]
        public string PROVINCE_ID { get; set; }

        [StringLength(50)]
        public string PROVINCE { get; set; }

        [StringLength(40)]
        public string CITY_ID { get; set; }

        [StringLength(50)]
        public string CITY { get; set; }

        [StringLength(40)]
        public string DISTRICT_ID { get; set; }

        [StringLength(50)]
        public string DISTRICT { get; set; }

        [StringLength(100)]
        public string ADDRESS { get; set; }

        [StringLength(10)]
        public string POST_CODE { get; set; }

        [StringLength(30)]
        public string PHONE { get; set; }

        [StringLength(30)]
        public string FAX { get; set; }

        [StringLength(30)]
        public string MOBILE { get; set; }

        [StringLength(60)]
        public string EMAIL { get; set; }

        [StringLength(20)]
        public string DELIVER_CATEGORY { get; set; }

        public int? SORT_CODE { get; set; }

        public int? DELETION_STATE_CODE { get; set; }

        public int? ENABLED { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public DateTime? CREATE_ON { get; set; }

        [StringLength(40)]
        public string CREATE_USER_ID { get; set; }

        [StringLength(30)]
        public string CREATE_BY { get; set; }

        public DateTime? MODIFIED_ON { get; set; }

        [StringLength(40)]
        public string MODIFIED_USER_ID { get; set; }

        [StringLength(30)]
        public string MODIFIED_BY { get; set; }

        public int? CATEGORY_CODE { get; set; }

        public int? DEFAULT_ADDRESS { get; set; }

        [StringLength(40)]
        public string EMPLOYEE_CODE { get; set; }

        [StringLength(40)]
        public string EMPLOYEE_ID { get; set; }

        [StringLength(20)]
        public string COMPANY_CODE { get; set; }

        [StringLength(8)]
        public string COMPANY_ID { get; set; }

        [StringLength(100)]
        public string BOX_CODE { get; set; }

        [StringLength(50)]
        public string STREET { get; set; }

        [StringLength(40)]
        public string STREET_ID { get; set; }
    }
}
