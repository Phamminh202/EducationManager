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
    
    public partial class student_fee
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int Semester_Id { get; set; }
        public decimal Fee { get; set; }
    
        public virtual semester semester { get; set; }
        public virtual user user { get; set; }
    }
}
