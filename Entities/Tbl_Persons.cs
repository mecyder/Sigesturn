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
    
    public partial class Tbl_Persons
    {
        public int personID { get; set; }
        public string personNames { get; set; }
        public string personLastName { get; set; }
        public string personFullName { get; set; }
        public string personPhone { get; set; }
        public string personEmail { get; set; }
        public string personaAdress { get; set; }
        public string personNoDocument { get; set; }
        public Nullable<int> personDocumentTyppe { get; set; }
        public System.DateTime createOn { get; set; }
        public Nullable<System.DateTime> personBirthdate { get; set; }
    }
}
