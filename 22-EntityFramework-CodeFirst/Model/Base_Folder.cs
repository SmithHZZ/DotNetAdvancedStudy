namespace _22_EntityFramework_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Folder
    {
        [StringLength(40)]
        public string ID { get; set; }

        [StringLength(40)]
        public string PARENT_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string FOLDER_NAME { get; set; }

        [StringLength(50)]
        public string STATE_CODE { get; set; }

        public int SORT_CODE { get; set; }

        public int ALLOW_EDIT { get; set; }

        public int ALLOW_DELETE { get; set; }

        public int IS_PUBLIC { get; set; }

        public int ENABLED { get; set; }

        public int DELETION_STATE_CODE { get; set; }

        [StringLength(200)]
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
    }
}
