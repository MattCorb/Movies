using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateME.Models
{
    public class DateApplicationContext : DbContext
    {
        //constuctor
        public DateApplicationContext(DbContextOptions<DateApplicationContext> options) : base(options)
        {
            //leave blank for now
        }

        public DbSet<ApplicationResponse> Responses {get; set;}


        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    ApplicationId = 1,
                    FirstName = "Matt",
                    LastName = "Corbett",
                    Age = 23,
                    PhoneNumber = "555-555",
                    Major = "IS",
                    Crepe = false

                },

                new ApplicationResponse
                {
                    ApplicationId = 2,
                    FirstName  = "Creed",
                    LastName = "Bratton",
                    Age = 50,
                    PhoneNumber = "0",
                    Major = "N/A",
                    Crepe = true
                }
                );
        }

    }
}
