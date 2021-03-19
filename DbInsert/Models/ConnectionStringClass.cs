using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;

namespace DbInsert.Models
{
    public class ConnectionStringClass:DbContext
    {
        // constructor
        public ConnectionStringClass(DbContextOptions<ConnectionStringClass> options): base(options)
        {

        }

        //property  -> table name
        public DbSet<EmpClass> employee { get; set; }
    }
}
