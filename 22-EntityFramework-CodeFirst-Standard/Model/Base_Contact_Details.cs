namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Contact_Details
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(40)]
        public string Contact_Id { get; set; }

        [StringLength(40)]
        public string Category { get; set; }

        [StringLength(40)]
        public string Receiver_Id { get; set; }

        [StringLength(40)]
        public string Receiver_Real_Name { get; set; }

        public int Is_New { get; set; }

        public int New_Comment { get; set; }

        public int Enabled { get; set; }

        public int? Replied { get; set; }

        [StringLength(40)]
        public string Last_View_IP { get; set; }

        [StringLength(40)]
        public string Last_View_Date { get; set; }

        public int Deletion_State_Code { get; set; }

        public int? Sort_Code { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public DateTime? Create_On { get; set; }

        [StringLength(20)]
        public string Create_User_Id { get; set; }

        [StringLength(20)]
        public string Create_By { get; set; }

        public DateTime? Modified_On { get; set; }

        [StringLength(20)]
        public string Modified_User_Id { get; set; }

        [StringLength(20)]
        public string Modified_By { get; set; }
    }
}
