//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ticketing_System.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mst_Project_Documents
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DocumentPath { get; set; }
        public string Description { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public string UploadedBy { get; set; }
        public Nullable<System.DateTime> UploadedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Mst_Project Mst_Project { get; set; }
    }
}