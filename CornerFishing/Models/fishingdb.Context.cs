﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CornerFishing.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class fishingDataEntity : DbContext
    {
        public fishingDataEntity()
            : base("name=fishingDataEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Event> Events { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Team> Teams { get; set; }
    
        public virtual ObjectResult<sp_GetEventResults_Result> sp_GetEventResults(Nullable<int> eventID)
        {
            var eventIDParameter = eventID.HasValue ?
                new ObjectParameter("EventID", eventID) :
                new ObjectParameter("EventID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetEventResults_Result>("sp_GetEventResults", eventIDParameter);
        }
    
        public virtual ObjectResult<string> sp_GetLastEvent()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_GetLastEvent");
        }
    
        public virtual ObjectResult<string> sp_GetNextEvent()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_GetNextEvent");
        }
    
        public virtual ObjectResult<sp_GetPointTotals_Result> sp_GetPointTotals()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetPointTotals_Result>("sp_GetPointTotals");
        }
    
        public virtual int sp_GetEventsForTeam(Nullable<int> teamID)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("TeamID", teamID) :
                new ObjectParameter("TeamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_GetEventsForTeam", teamIDParameter);
        }
    }
}
