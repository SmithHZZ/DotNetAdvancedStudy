namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Staff
    {
        [StringLength(40)]
        public string ID { get; set; }

        [StringLength(40)]
        public string USER_ID { get; set; }

        [StringLength(50)]
        public string USER_NAME { get; set; }

        [StringLength(50)]
        public string REAL_NAME { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string GENDER { get; set; }

        [StringLength(8)]
        public string COMPANY_ID { get; set; }

        [StringLength(8)]
        public string SUB_COMPANY_ID { get; set; }

        [StringLength(40)]
        public string DEPARTMENT_ID { get; set; }

        [StringLength(40)]
        public string WORKGROUP_ID { get; set; }

        [StringLength(100)]
        public string QUICK_QUERY { get; set; }

        [StringLength(40)]
        public string DUTY_ID { get; set; }

        [StringLength(20)]
        public string DUTY_CODE { get; set; }

        [StringLength(20)]
        public string DUTY_TYPE { get; set; }

        [StringLength(20)]
        public string DUTY_LEVEL { get; set; }

        [StringLength(30)]
        public string DUTY { get; set; }

        [StringLength(40)]
        public string IDENTIFICATION_CODE { get; set; }

        [StringLength(50)]
        public string ID_CARD { get; set; }

        [StringLength(50)]
        public string BANK_CODE { get; set; }

        [StringLength(50)]
        public string REWAR_CARD { get; set; }

        [StringLength(50)]
        public string MEDICAL_CARD { get; set; }

        [StringLength(50)]
        public string UNION_MEMBER { get; set; }

        [StringLength(200)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string MOBILE { get; set; }

        [StringLength(50)]
        public string SHORT_NUMBER { get; set; }

        [StringLength(50)]
        public string TELEPHONE { get; set; }

        [StringLength(50)]
        public string QQ { get; set; }

        [StringLength(50)]
        public string OFFICE_PHONE { get; set; }

        [StringLength(50)]
        public string OFFICE_POSTCODE { get; set; }

        [StringLength(200)]
        public string OFFICE_ADDRESS { get; set; }

        [StringLength(50)]
        public string OFFICE_FAX { get; set; }

        [StringLength(50)]
        public string AGE { get; set; }

        [StringLength(50)]
        public string BIRTHDAY { get; set; }

        [StringLength(50)]
        public string HEIGHT { get; set; }

        [StringLength(50)]
        public string WEIGHT { get; set; }

        [StringLength(50)]
        public string EDUCATION { get; set; }

        [StringLength(50)]
        public string SCHOOL { get; set; }

        [StringLength(50)]
        public string GRADUATION_DATE { get; set; }

        [StringLength(100)]
        public string MAJOR { get; set; }

        [StringLength(50)]
        public string DEGREE { get; set; }

        [StringLength(40)]
        public string TITLE_ID { get; set; }

        [StringLength(50)]
        public string TITLE_DATE { get; set; }

        [StringLength(50)]
        public string TITLE_LEVEL { get; set; }

        [StringLength(30)]
        public string TITLE { get; set; }

        [StringLength(50)]
        public string WORKING_DATE { get; set; }

        [StringLength(50)]
        public string JOIN_IN_DATE { get; set; }

        [StringLength(50)]
        public string HOME_POST_CODE { get; set; }

        [StringLength(200)]
        public string HOME_ADDRESS { get; set; }

        [StringLength(50)]
        public string HOME_PHONE { get; set; }

        [StringLength(50)]
        public string HOME_FAX { get; set; }

        [StringLength(50)]
        public string PROVINCE { get; set; }

        [StringLength(50)]
        public string CAR_CODE { get; set; }

        [StringLength(50)]
        public string CITY { get; set; }

        [StringLength(50)]
        public string AREA { get; set; }

        [StringLength(50)]
        public string NATIVE_PLACE { get; set; }

        [StringLength(50)]
        public string PARTY { get; set; }

        [StringLength(50)]
        public string NATION { get; set; }

        [StringLength(50)]
        public string NATIONALITY { get; set; }

        [StringLength(100)]
        public string WORKING_PROPERTY { get; set; }

        [StringLength(100)]
        public string COMPETENCY { get; set; }

        [StringLength(200)]
        public string EMERGENCY_CONTACT { get; set; }

        public DateTime? WEDDING_DAY { get; set; }

        public DateTime? DIVORCE { get; set; }

        public DateTime? CHILD_BIRTHDAY1 { get; set; }

        public DateTime? CHILD_BIRTHDAY2 { get; set; }

        public int? IS_DIMISSION { get; set; }

        [StringLength(50)]
        public string DIMISSION_DATE { get; set; }

        [StringLength(800)]
        public string DIMISSION_CAUSE { get; set; }

        [StringLength(100)]
        public string DIMISSION_WHITHER { get; set; }

        public int? ENABLED { get; set; }

        public int? DELETION_STATE_CODE { get; set; }

        public int? SORT_CODE { get; set; }

        [StringLength(800)]
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

        [StringLength(50)]
        public string CURRENT_DISTRICT { get; set; }

        [StringLength(50)]
        public string CURRENT_CITY { get; set; }

        [StringLength(50)]
        public string CURRENT_PROVINCE { get; set; }

        [StringLength(50)]
        public string DISTRICT { get; set; }

        [StringLength(50)]
        public string COMPANY_NAME { get; set; }

        [StringLength(50)]
        public string DEPARTMENT_NAME { get; set; }

        [StringLength(50)]
        public string WORKGROUP_NAME { get; set; }

        [StringLength(20)]
        public string MARRIAGE { get; set; }

        [StringLength(20)]
        public string EXTENSION { get; set; }

        [StringLength(50)]
        public string BANK_NAME { get; set; }

        [StringLength(50)]
        public string BANK_USER_NAME { get; set; }
    }
}
