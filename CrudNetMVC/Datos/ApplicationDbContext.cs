using CrudNetMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudNetMVC.Datos
{
	public class ApplicationDbContext:DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ): base(options)
		{
			
		}

		//Agregar los modelos (tablas) aquí ... Modelos en singular; Controladores Plural
		public DbSet<Contacto> Contacto { get; set; }
	}
}