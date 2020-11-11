namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_News
    {
        [StringLength(40)]
        public string ID { get; set; }

        [StringLength(40)]
        public string FOLDER_ID { get; set; }

        [StringLength(8)]
        public string COMPANY_ID { get; set; }

        [StringLength(30)]
        public string COMPANY_NAME { get; set; }

        [StringLength(40)]
        public string DEPARTMENT_ID { get; set; }

        [StringLength(30)]
        public string DEPARTMENT_NAME { get; set; }

        [StringLength(20)]
        public string CATEGORY_CODE { get; set; }

        [StringLength(30)]
        public string CODE { get; set; }

        [StringLength(40)]
        public string TITLE { get; set; }

        [StringLength(200)]
        public string FILE_PATH { get; set; }

        [StringLength(200)]
        public string INTRODUCTION { get; set; }

        [Column(TypeName = "text")]
        public string CONTENTS { get; set; }

        [StringLength(200)]
        public string SOURCE { get; set; }

        [StringLength(200)]
        public string KEYWORDS { get; set; }

        public int? FILE_SIZE { get; set; }

        [StringLength(200)]
        public string IMAGE_URL { get; set; }

        public int? HOME_PAGE { get; set; }

        public int? SUB_PAGE { get; set; }

        [StringLength(20)]
        public string AUDIT_STATUS { get; set; }

        public int? READ_COUNT { get; set; }

        public int? DELETION_STATE_CODE { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public int? ENABLED { get; set; }

        public int? SORT_CODE { get; set; }

        public DateTime? CREATE_ON { get; set; }

        [StringLength(30)]
        public string CREATE_BY { get; set; }

        [StringLength(40)]
        public string CREATE_USER_ID { get; set; }

        public DateTime? MODIFIED_ON { get; set; }

        [StringLength(30)]
        public string MODIFIED_BY { get; set; }

        [StringLength(40)]
        public string MODIFIED_USER_ID { get; set; }
    }
}
