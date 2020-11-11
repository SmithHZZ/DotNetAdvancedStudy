namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class System_Parameter
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(40)]
        public string Category_Code { get; set; }

        [StringLength(40)]
        public string Parameter_Id { get; set; }

        [StringLength(40)]
        public string Parameter_Code { get; set; }

        [StringLength(2000)]
        public string Parameter_Content { get; set; }

        public int Worked { get; set; }

        public int Enabled { get; set; }

        public int? Deletion_State_Code { get; set; }

        public int? Sort_Code { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Create_On { get; set; }

        [StringLength(40)]
        public string Create_User_Id { get; set; }

        [StringLength(20)]
        public string Create_By { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Modified_On { get; set; }

        [StringLength(40)]
        public string Modified_User_Id { get; set; }

        [StringLength(20)]
        public string Modified_By { get; set; }
    }
}
