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
    
    public partial class Base_Area
    {
        public int Id { get; set; }
        public Nullable<int> Parent_Id { get; set; }
        public string Code { get; set; }
        public string Short_Name { get; set; }
        public string Full_Name { get; set; }
        public string Quick_Query { get; set; }
        public string Simple_Spelling { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Postal_code { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public Nullable<short> Allow_Edit { get; set; }
        public Nullable<short> Allow_Delete { get; set; }
        public string Description { get; set; }
        public Nullable<int> Sort_Code { get; set; }
        public Nullable<int> Layer { get; set; }
        public Nullable<short> Network_Orders { get; set; }
        public short Allow_To_Pay { get; set; }
        public int Max_To_Payment { get; set; }
        public short Allow_Goods_Pay { get; set; }
        public int Max_Goods_Payment { get; set; }
        public short Whole { get; set; }
        public short Receive { get; set; }
        public short Send { get; set; }
        public string Mark { get; set; }
        public Nullable<short> Out_Of_Range { get; set; }
        public Nullable<short> OPENING { get; set; }
        public string PRINT_MARK { get; set; }
        public Nullable<short> DELAY_DAY { get; set; }
        public string STATISTICS { get; set; }
        public short Is_Public { get; set; }
        public short Enabled { get; set; }
        public short Deletion_State_Code { get; set; }
        public Nullable<System.DateTime> Create_On { get; set; }
        public string Create_User_Id { get; set; }
        public string Create_By { get; set; }
        public Nullable<System.DateTime> Modified_On { get; set; }
        public string Modified_User_Id { get; set; }
        public string Modified_By { get; set; }
        public string Manage_Company_Id { get; set; }
        public string Manage_Company_Code { get; set; }
        public string Manage_Company { get; set; }
        public string MODIFIED_COMPANY_ID { get; set; }
        public string MODIFIED_COMPANY { get; set; }
        public string MODIFIED_COMPANY_CODE { get; set; }
    }
}