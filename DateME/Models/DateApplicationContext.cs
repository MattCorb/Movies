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

        //seed the database with json objects
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    ApplicationId = 1,
                    Category = "Comdedy",
                    Title = "Dumb & Dumber",
                    Year = 1994,
                    Director = "The Farrelly Brothers",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = null

                },

                new ApplicationResponse
                {
                    ApplicationId = 2,
                    Category = "Comdedy",
                    Title = "Ferris Bueller’s Day Off",
                    Year = 1986,
                    Director = "John Hughes",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },
                new ApplicationResponse
                 {
                     ApplicationId = 3,
                     Category = "Comdedy",
                     Title = "Fletch",
                     Year = 1985,
                     Director = "Michael Ritchie",
                     Rating = "PG",
                     Edited = false,
                     LentTo = null,
                     Notes = null
                 }
               );
        }

    }
}
