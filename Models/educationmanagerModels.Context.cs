﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class educationmanagerEntities : DbContext
    {
        public educationmanagerEntities()
            : base("name=educationmanagerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<academicyear> academicyear { get; set; }
        public virtual DbSet<action> action { get; set; }
        public virtual DbSet<application> application { get; set; }
        public virtual DbSet<attendance_report> attendance_report { get; set; }
        public virtual DbSet<@class> @class { get; set; }
        public virtual DbSet<course> course { get; set; }
        public virtual DbSet<exams> exams { get; set; }
        public virtual DbSet<mark> mark { get; set; }
        public virtual DbSet<parent> parent { get; set; }
        public virtual DbSet<role> role { get; set; }
        public virtual DbSet<semester> semester { get; set; }
        public virtual DbSet<student_fee> student_fee { get; set; }
        public virtual DbSet<timetable> timetable { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<userinacademicyear> userinacademicyear { get; set; }
        public virtual DbSet<userinclass> userinclass { get; set; }
        public virtual DbSet<userincourse> userincourse { get; set; }
        public virtual DbSet<userinexams> userinexams { get; set; }
        public virtual DbSet<userrole> userrole { get; set; }
    }
}
