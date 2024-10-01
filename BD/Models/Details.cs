using System.ComponentModel.DataAnnotations;

namespace BD.Models
{
	public class Details
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; } = null!;
		public double Price { get; set; }
		public int CountryId { get; set; }
		public Country Country { get; set; } = null!;
		public int Part_typeId { get; set; }
		public Type Part_type { get; set; } = null!;
		public string? Model { get; set; }
		public double Operating_voltage { get; set; }
		public int MinOperating_Temp { get; set; }
		public int MaxOperating_Temp { get; set; }
		public double Capacity { get; set; }
		public double Power { get; set; }
		public double Resistance { get; set; }
		public double Electric_current { get; set; }
		public double Inductance { get; set; }
		public int MaterialId { get; set; }
		public Material Material { get; set; } = null!;
		public int ManufacturerId { get; set; }
		public Manufacturer Manufacturer { get; set; } = null!;

	}
}
