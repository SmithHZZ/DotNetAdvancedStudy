//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace _22_EntityFramework_DBFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Colp_Biopsy_Detail
    {
        public string ID { get; set; }
        public string Parent_Id { get; set; }
        public string Parent_Name { get; set; }
        public string Parent_Code { get; set; }
        public string Organization_Id { get; set; }
        public string Organization_Name { get; set; }
        public string Organization_Code { get; set; }
        public string Department_Id { get; set; }
        public string Department_Name { get; set; }
        public string Department_Code { get; set; }
        public string Equipment_Id { get; set; }
        public string Equipment_Name { get; set; }
        public string Equipment_Code { get; set; }
        public string User_Id { get; set; }
        public string User_Name { get; set; }
        public string User_Code { get; set; }
        public Nullable<System.DateTime> BiopsyDate { get; set; }
        public string Code { get; set; }
        public string BiopsyInspect { get; set; }
        public string BiopsyPathologyResult { get; set; }
        public string PostoperativePathologyResult { get; set; }
        public string BiopsyCut { get; set; }
        public string LesionLocation { get; set; }
        public Nullable<int> BiopsySum { get; set; }
        public string DisposeSuggestion { get; set; }
        public string DisposeRemark { get; set; }
        public Nullable<System.DateTime> RevisitDate { get; set; }
        public string Selected_Pictures { get; set; }
        public string Associated_Documents { get; set; }
        public string Full_Name { get; set; }
        public string Name { get; set; }
        public string Category_Code { get; set; }
        public string Category { get; set; }
        public Nullable<short> State_Code { get; set; }
        public string State { get; set; }
        public Nullable<int> Sort_Code { get; set; }
        public Nullable<short> Allow_Edit { get; set; }
        public Nullable<short> Allow_Delete { get; set; }
        public Nullable<short> Is_Visible { get; set; }
        public Nullable<short> Is_Public { get; set; }
        public Nullable<short> Enabled { get; set; }
        public Nullable<short> Deletion_State_Code { get; set; }
        public string Contents { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
        public System.DateTime Create_On { get; set; }
        public string Create_User_Id { get; set; }
        public string Create_By { get; set; }
        public System.DateTime Modified_On { get; set; }
        public string Modified_User_Id { get; set; }
        public string Modified_By { get; set; }
    }
}
