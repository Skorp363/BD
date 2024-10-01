namespace BD.Models
{
	public class Type
	{
		public int Id { get; set; }
		public int Code { get; set; }
		public string Name { get; set; } = null!;
		public List<Details> Details { get; set; } = new();
	}
}
