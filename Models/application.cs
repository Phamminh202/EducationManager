//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EducationManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class application
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int Course_Id { get; set; }
        public int Class_Id { get; set; }
        public System.DateTime Create_Date { get; set; }
    
        public virtual user user { get; set; }
        public virtual course course { get; set; }
        public virtual @class @class { get; set; }
    }
}
