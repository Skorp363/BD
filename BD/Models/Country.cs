namespace BD.Models
{
	public class Country
	{
		public int Id { get; set; }
		public string Code { get; set; } = null!;
		public string Name { get; set; } = null!;
		public List<Details> Details { get; set; } = new();
	}
}
