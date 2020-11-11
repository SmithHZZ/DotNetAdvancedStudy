namespace _22_EntityFramework_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Option_Items_Disability
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        [StringLength(40)]
        public string ItemCode { get; set; }

        [StringLength(100)]
        public string ItemName { get; set; }

        [StringLength(100)]
        public string ItemValue { get; set; }

        public int Enabled { get; set; }

        public int AllowEdit { get; set; }

        public int AllowDelete { get; set; }

        public int IsPublic { get; set; }

        public int DeletionStateCode { get; set; }

        public int? SortCode { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Create_On { get; set; }

        [StringLength(20)]
        public string Create_User_Id { get; set; }

        [StringLength(20)]
        public string Create_By { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Modified_On { get; set; }

        [StringLength(20)]
        public string Modified_User_Id { get; set; }

        [StringLength(20)]
        public string Modified_By { get; set; }
    }
}
