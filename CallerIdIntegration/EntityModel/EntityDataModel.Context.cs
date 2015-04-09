﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CallerIdIntegration.EntityModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class PCApp_TaxitechEntities : DbContext
    {
        public PCApp_TaxitechEntities()
            : base("name=PCApp_TaxitechEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<cab> cabs { get; set; }
        public DbSet<call> calls { get; set; }
        public DbSet<caller_data> caller_data { get; set; }
        public DbSet<contact> contacts { get; set; }
        public DbSet<device> devices { get; set; }
        public DbSet<dispacher_fares> dispacher_fares { get; set; }
        public DbSet<dispacher_trips> dispacher_trips { get; set; }
        public DbSet<dispacher> dispachers { get; set; }
        public DbSet<driver> drivers { get; set; }
        public DbSet<notification_logs> notification_logs { get; set; }
        public DbSet<reservation> reservations { get; set; }
        public DbSet<triplog> triplogs { get; set; }
        public DbSet<trip> trips { get; set; }
        public DbSet<url_sends> url_sends { get; set; }
        public DbSet<vehicle> vehicles { get; set; }
    
        public virtual ObjectResult<uspGetTripLogInformation_Result> uspGetTripLogInformation(Nullable<int> dispatcherID, string currentDate)
        {
            var dispatcherIDParameter = dispatcherID.HasValue ?
                new ObjectParameter("DispatcherID", dispatcherID) :
                new ObjectParameter("DispatcherID", typeof(int));
    
            var currentDateParameter = currentDate != null ?
                new ObjectParameter("CurrentDate", currentDate) :
                new ObjectParameter("CurrentDate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetTripLogInformation_Result>("uspGetTripLogInformation", dispatcherIDParameter, currentDateParameter);
        }
    
        public virtual ObjectResult<uspSearchCompletedTrips_Result> uspSearchCompletedTrips(string keyword, string startdate, string enddate, Nullable<int> dispatcherid)
        {
            var keywordParameter = keyword != null ?
                new ObjectParameter("keyword", keyword) :
                new ObjectParameter("keyword", typeof(string));
    
            var startdateParameter = startdate != null ?
                new ObjectParameter("Startdate", startdate) :
                new ObjectParameter("Startdate", typeof(string));
    
            var enddateParameter = enddate != null ?
                new ObjectParameter("Enddate", enddate) :
                new ObjectParameter("Enddate", typeof(string));
    
            var dispatcheridParameter = dispatcherid.HasValue ?
                new ObjectParameter("Dispatcherid", dispatcherid) :
                new ObjectParameter("Dispatcherid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspSearchCompletedTrips_Result>("uspSearchCompletedTrips", keywordParameter, startdateParameter, enddateParameter, dispatcheridParameter);
        }
    
        public virtual ObjectResult<uspSearchReservationTrips_Result> uspSearchReservationTrips(string keyword, Nullable<int> dispatcherid, string date)
        {
            var keywordParameter = keyword != null ?
                new ObjectParameter("keyword", keyword) :
                new ObjectParameter("keyword", typeof(string));
    
            var dispatcheridParameter = dispatcherid.HasValue ?
                new ObjectParameter("Dispatcherid", dispatcherid) :
                new ObjectParameter("Dispatcherid", typeof(int));
    
            var dateParameter = date != null ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspSearchReservationTrips_Result>("uspSearchReservationTrips", keywordParameter, dispatcheridParameter, dateParameter);
        }
    }
}