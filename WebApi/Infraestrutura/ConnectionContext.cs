﻿using Microsoft.EntityFrameworkCore;
using WebApi.Domain.Model;

namespace WebApi.Infraestrutura
{
    public class ConnectionContext : DbContext
	{
		public DbSet<Employee> Employees { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
				 => optionsBuilder.UseNpgsql(
						 "Server=localhost;" +
						 "Port=5432;Database=postgres;" +
						 "User Id=postgres;" +
						 "Password=1234;");
	}
}

