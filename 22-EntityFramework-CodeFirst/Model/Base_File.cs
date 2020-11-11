namespace _22_EntityFramework_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_File
    {
        [StringLength(40)]
        public string ID { get; set; }

        [StringLength(40)]
        public string FOLDER_ID { get; set; }

        [StringLength(200)]
        public string FILE_NAME { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string FILE_PATH { get; set; }

        [StringLength(50)]
        public string CATEGORY_CODE { get; set; }

        [StringLength(500)]
        public string INTRODUCTION { get; set; }

        [StringLength(200)]
        public string IMAGE_URL { get; set; }

        [StringLength(500)]
        public string KEY_WORDS { get; set; }

        [StringLength(500)]
        public string SOURCE { get; set; }

        public int? HOME_PAGE { get; set; }

        public int? SUB_PAGE { get; set; }

        [MaxLength(4000)]
        public byte[] CONTENTS { get; set; }

        public int? READ_COUNT { get; set; }

        public int? FILE_SIZE { get; set; }

        [StringLength(50)]
        public string AUDIT_STATUS { get; set; }

        public int? ENABLED { get; set; }

        public int? DELETION_STATE_CODE { get; set; }

        public int? SORT_CODE { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        [StringLength(50)]
        public string CREATE_BY { get; set; }

        [StringLength(40)]
        public string CREATE_USER_ID { get; set; }

        public DateTime? CREATE_ON { get; set; }

        [StringLength(50)]
        public string MODIFIE_DBY { get; set; }

        [StringLength(40)]
        public string MODIFIED_USER_ID { get; set; }

        public DateTime? MODIFIED_ON { get; set; }
    }
}
