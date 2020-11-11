namespace _22_EntityFramework_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BASE_ORGANIZE_HORIZONTAL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string FULL_NAME { get; set; }

        [StringLength(8)]
        public string HEADQUARTERS_ID { get; set; }

        [StringLength(10)]
        public string HEADQUARTERS_CODE { get; set; }

        [StringLength(20)]
        public string HEADQUARTERS { get; set; }

        [StringLength(20)]
        public string BIG_AREA_CODE { get; set; }

        [StringLength(20)]
        public string BIG_AREA { get; set; }

        [StringLength(20)]
        public string AREA_CODE { get; set; }

        [StringLength(20)]
        public string AREA { get; set; }

        [StringLength(8)]
        public string TRANSFER_FIRST_ID { get; set; }

        [StringLength(200)]
        public string TRANSFER_FIRST_CODE { get; set; }

        [StringLength(20)]
        public string TRANSFER_FIRST { get; set; }

        [StringLength(8)]
        public string COMPANY_FIRST_ID { get; set; }

        [StringLength(10)]
        public string COMPANY_FIRST_CODE { get; set; }

        [StringLength(20)]
        public string COMPANY_FIRST { get; set; }

        [StringLength(8)]
        public string COMPANY_SECOND_ID { get; set; }

        [StringLength(10)]
        public string COMPANY_SECOND_CODE { get; set; }

        [StringLength(20)]
        public string COMPANY_SECOND { get; set; }

        [StringLength(8)]
        public string CONTRACT_ID { get; set; }

        [StringLength(10)]
        public string CONTRACT_CODE { get; set; }

        [StringLength(20)]
        public string CONTRACT { get; set; }

        [StringLength(8)]
        public string PARENT_ID { get; set; }

        [StringLength(20)]
        public string PARENT_NAME { get; set; }

        [StringLength(10)]
        public string PARENT_CODE { get; set; }

        [StringLength(40)]
        public string COUNTRY_ID { get; set; }

        [StringLength(20)]
        public string COUNTRY_CODE { get; set; }

        [StringLength(50)]
        public string COUNTRY { get; set; }

        [StringLength(40)]
        public string PROVINCE_ID { get; set; }

        [StringLength(20)]
        public string PROVINCE_CODE { get; set; }

        [StringLength(50)]
        public string PROVINCE { get; set; }

        [StringLength(40)]
        public string CITY_ID { get; set; }

        [StringLength(20)]
        public string CITY_CODE { get; set; }

        [StringLength(50)]
        public string CITY { get; set; }

        [StringLength(40)]
        public string DISTRICT_ID { get; set; }

        [StringLength(20)]
        public string DISTRICT_CODE { get; set; }

        [StringLength(50)]
        public string DISTRICT { get; set; }

        [StringLength(40)]
        public string STREET_ID { get; set; }

        [StringLength(20)]
        public string STREET_CODE { get; set; }

        [StringLength(50)]
        public string STREET { get; set; }

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

        [StringLength(10)]
        public string CATEGORY { get; set; }
    }
}
