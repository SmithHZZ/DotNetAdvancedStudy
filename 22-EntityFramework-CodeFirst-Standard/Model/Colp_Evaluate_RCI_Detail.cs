namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Colp_Evaluate_RCI_Detail
    {
        [StringLength(36)]
        public string Id { get; set; }

        [StringLength(36)]
        public string Parent_Id { get; set; }

        [StringLength(196)]
        public string Parent_Name { get; set; }

        [StringLength(40)]
        public string Parent_Code { get; set; }

        [StringLength(40)]
        public string Code { get; set; }

        [StringLength(196)]
        public string Full_Name { get; set; }

        [StringLength(196)]
        public string Name { get; set; }

        [StringLength(196)]
        public string Boundary { get; set; }

        public int? BoundaryNum { get; set; }

        [StringLength(196)]
        public string Colour { get; set; }

        public int? ColourNum { get; set; }

        [StringLength(196)]
        public string Bloodvessel { get; set; }

        public int? BloodvesselNum { get; set; }

        [StringLength(196)]
        public string Iodinestaining { get; set; }

        public int? IodinestainingNum { get; set; }

        public int? SumAppraisesCore { get; set; }

        [StringLength(196)]
        public string RCIAppraiseResult { get; set; }

        public DateTime? RCIAppraiseDate { get; set; }

        public string Selected_Pictures { get; set; }

        public string Associated_Documents { get; set; }

        [StringLength(40)]
        public string Category_Code { get; set; }

        [StringLength(196)]
        public string Category { get; set; }

        public short? State_Code { get; set; }

        [StringLength(196)]
        public string State { get; set; }

        public int? Sort_Code { get; set; }

        public short? Allow_Edit { get; set; }

        public short? Allow_Delete { get; set; }

        public short? Is_Visible { get; set; }

        public short? Is_Public { get; set; }

        public short? Enabled { get; set; }

        public short? Deletion_State_Code { get; set; }

        public string Contents { get; set; }

        public string Description { get; set; }

        public string Tag { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Create_On { get; set; }

        [Required]
        [StringLength(36)]
        public string Create_User_Id { get; set; }

        [Required]
        [StringLength(196)]
        public string Create_By { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Modified_On { get; set; }

        [Required]
        [StringLength(36)]
        public string Modified_User_Id { get; set; }

        [Required]
        [StringLength(196)]
        public string Modified_By { get; set; }
    }
}
