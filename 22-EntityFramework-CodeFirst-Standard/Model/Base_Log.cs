namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Log
    {
        [StringLength(40)]
        public string ID { get; set; }

        [StringLength(40)]
        public string TASK_ID { get; set; }

        [StringLength(50)]
        public string SERVICE { get; set; }

        [StringLength(40)]
        public string USER_ID { get; set; }

        [StringLength(30)]
        public string USER_REAL_NAME { get; set; }

        [StringLength(200)]
        public string PARAMETERS { get; set; }

        [StringLength(200)]
        public string URL_REFERRER { get; set; }

        [StringLength(30)]
        public string CLIENT_IP { get; set; }

        [StringLength(30)]
        public string SERVER_IP { get; set; }

        [StringLength(800)]
        public string DESCRIPTION { get; set; }

        public int? ELAPSED_TICKS { get; set; }

        [StringLength(8)]
        public string COMPANY_ID { get; set; }

        [StringLength(50)]
        public string IPADDRESS { get; set; }

        public string Category_Code { get; set; }

        public string Category { get; set; }

        public short? State_Code { get; set; }

        [Required]
        public string State { get; set; }

        public int? Sort_Code { get; set; }

        public short? Allow_Edit { get; set; }

        public short? Allow_Delete { get; set; }

        public short? Is_Visible { get; set; }

        public short? Is_Public { get; set; }

        public short? Enabled { get; set; }

        public short? Deletion_State_Code { get; set; }

        public DateTime? CREATE_ON { get; set; }

        public DateTime? MODIFIED_ON { get; set; }

        [StringLength(200)]
        public string WEB_URL { get; set; }

        [StringLength(20)]
        public string COMPANY { get; set; }

        [StringLength(40)]
        public string CREATE_USER_ID { get; set; }

        [StringLength(30)]
        public string CREATE_BY { get; set; }

        [StringLength(40)]
        public string MODIFIED_USER_ID { get; set; }

        [StringLength(30)]
        public string MODIFIED_BY { get; set; }
    }
}
