using Framework.Repository;
using Microsoft.EntityFrameworkCore;
using OnlineQuizSystem.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizSystem.Repository.DataBase;

public class OnlineQuizSystemContext : BaseDbContext
{
	public OnlineQuizSystemContext(DbContextOptions<OnlineQuizSystemContext> options) : base (options)
	{

	}

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OnlineQuizSystemDb;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    //}


    protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Employee>().ToTable("Employees");
		modelBuilder.Entity<Employee>().HasKey(e => e.Id);
		modelBuilder.Entity<Employee>().Property(e => e.FirstName).HasMaxLength(50).IsRequired();
		modelBuilder.Entity<Employee>().Property(e => e.LastName).HasMaxLength(50).IsRequired();
		modelBuilder.Entity<Employee>().Property(e => e.NationalCode).HasMaxLength(10).IsRequired();
		modelBuilder.Entity<Employee>().Property(e => e.BirthDate).HasColumnType(nameof(SqlDbType.DateTime2)).IsRequired();
	}
}
