using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RP.Data.DataContext
{
    public class SampleDataContext : DbContext
    {
        public SampleDataContext(DbContextOptions<SampleDataContext> options,IServiceProvider services) : base(options)
        {
            
        }


    }
}
