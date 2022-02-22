using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Taxopark.Infrastructure.Data
{
    public class TaxoparkContext : DbContext
    {
        public TaxoparkContext(DbContextOptions options) : base(options)
        {
        }
    }
}
