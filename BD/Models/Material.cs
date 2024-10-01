namespace BD.Models
{
	public class Material
	{
		public int Id { get; set; }
		public int Code { get; set; }
		public string Name { get; set; } = null!;
		public List<Details> Details { get; set; } = new();

	}
}
