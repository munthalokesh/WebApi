﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AirportManagementEntities : DbContext
    {
        public AirportManagementEntities()
            : base("name=AirportManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Pilot> Pilots { get; set; }
        public virtual DbSet<HangerDetail> HangerDetails { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Owner> Owner { get; set; }
        public virtual DbSet<Planes> Planes { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Login> Login { get; set; }
    
        public virtual ObjectResult<GetAvailableHangars_Result> GetAvailableHangars(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAvailableHangars_Result>("GetAvailableHangars", fromDateParameter, toDateParameter);
        }
    
        public virtual ObjectResult<GetAvailableHangarsDetails_Result> GetAvailableHangarsDetails(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAvailableHangarsDetails_Result>("GetAvailableHangarsDetails", fromDateParameter, toDateParameter);
        }
    
        public virtual ObjectResult<GetAvailablePlanes_Result> GetAvailablePlanes(Nullable<System.DateTime> selectedFromDate, Nullable<System.DateTime> selectedToDate)
        {
            var selectedFromDateParameter = selectedFromDate.HasValue ?
                new ObjectParameter("SelectedFromDate", selectedFromDate) :
                new ObjectParameter("SelectedFromDate", typeof(System.DateTime));
    
            var selectedToDateParameter = selectedToDate.HasValue ?
                new ObjectParameter("SelectedToDate", selectedToDate) :
                new ObjectParameter("SelectedToDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAvailablePlanes_Result>("GetAvailablePlanes", selectedFromDateParameter, selectedToDateParameter);
        }
    }
}
