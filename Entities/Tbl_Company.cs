//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Company
    {
        public int companyID { get; set; }
        public string companyName { get; set; }
        public string companyPhone { get; set; }
        public string companyAddress { get; set; }
        public string companyEmail { get; set; }
        public byte[] companyLogoURL { get; set; }
        public Nullable<int> configurationID { get; set; }
    }
}
