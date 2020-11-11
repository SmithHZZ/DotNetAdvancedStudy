namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Exception
    {
        [StringLength(40)]
        public string ID { get; set; }

        [StringLength(50)]
        public string SYSTEM_CODE { get; set; }

        public int? EVENT_ID { get; set; }

        [StringLength(64)]
        public string CATEGORY { get; set; }

        public int? PRIORITY { get; set; }

        [StringLength(50)]
        public string SEVERITY { get; set; }

        [StringLength(50)]
        public string IPADDRESS { get; set; }

        [StringLength(250)]
        public string TITLE { get; set; }

        public DateTime? TIMESTAMP { get; set; }

        [StringLength(200)]
        public string MACHINE_NAME { get; set; }

        [StringLength(2000)]
        public string APPDOMAIN_NAME { get; set; }

        [StringLength(256)]
        public string PROCESS_ID { get; set; }

        [StringLength(2000)]
        public string PROCESS_NAME { get; set; }

        [StringLength(2000)]
        public string THREAD_NAME { get; set; }

        [StringLength(200)]
        public string WIN32_THREAD_ID { get; set; }

        [StringLength(2000)]
        public string MESSAGE { get; set; }

        [StringLength(4000)]
        public string FORMATTED_MESSAGE { get; set; }

        public DateTime? CREATE_ON { get; set; }

        [StringLength(40)]
        public string CREATE_USER_ID { get; set; }

        [StringLength(50)]
        public string CREATE_BY { get; set; }
    }
}
