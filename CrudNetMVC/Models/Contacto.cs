using System.ComponentModel.DataAnnotations;

namespace CrudNetMVC.Models
{
	public class Contacto
	{
		[Key] //Se indica explícitamente que es llave primaria y autoincremental... debe ser int... Solo por Llamarse Id ya .net sabe que es PK
		public int Id { get; set; }

		[Required(ErrorMessage ="El nombre de obligatorio")]
		public string Nombre { get; set; }

		[Required(ErrorMessage = "El teléfono de obligatorio")]
		public string Telefono { get; set; }

		[Required(ErrorMessage = "El celular de obligatorio")]
		public string Celular { get; set; }

		[Required(ErrorMessage = "El email de obligatorio")]
		public string Email { get; set; }

		public DateTime FechaCreacion { get; set; }
	}
}
