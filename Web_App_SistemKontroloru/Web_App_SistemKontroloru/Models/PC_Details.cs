//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_App_SistemKontroloru.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PC_Details
    {
        public int id { get; set; }
        public int User_Id { get; set; }
        public string Hardware_Id { get; set; }
        public string Bg_Url { get; set; }
        public string Domain_User_Name { get; set; }
        public string Version_ { get; set; }
        public Nullable<double> Memory_Size_Gb { get; set; }
        public string Processor_Name { get; set; }
        public string Motherboard_Info { get; set; }
        public Nullable<int> Time_Limit_Minutes { get; set; }
        public Nullable<System.DateTime> Time_ { get; set; }
        public Nullable<bool> Status_ { get; set; }
        public Nullable<System.DateTime> Last_Sync { get; set; }
        public Nullable<bool> Online { get; set; }
    }
}
