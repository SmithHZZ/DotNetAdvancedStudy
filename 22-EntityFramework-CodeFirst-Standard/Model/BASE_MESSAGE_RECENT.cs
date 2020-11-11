namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BASE_MESSAGE_RECENT
    {
        [StringLength(40)]
        public string ID { get; set; }

        [StringLength(40)]
        public string USER_ID { get; set; }

        [StringLength(50)]
        public string TARGET_CATEGORY { get; set; }

        [StringLength(40)]
        public string TARGET_ID { get; set; }

        [StringLength(50)]
        public string REAL_NAME { get; set; }

        [StringLength(50)]
        public string COMPANY_NAME { get; set; }

        [StringLength(50)]
        public string DEPARTMENT_NAME { get; set; }

        public DateTime? MODIFIED_ON { get; set; }
    }
}
