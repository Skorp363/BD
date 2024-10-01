using System.ComponentModel.DataAnnotations;

namespace BD.Models
{
	public class Manufacturer
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string? Address { get; set; }
		public string? Country { get; set; }
		public string? Phone { get; set; }
		public string? Director { get; set; }
		public string? Activity { get; set; }
		public List<Details> Details { get; set; } = new();


	}
}
