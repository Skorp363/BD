using BD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BD.Pages
{
	[IgnoreAntiforgeryToken]
	public class StatisticModel : PageModel
    {
        private readonly ApplicationContext context;
		public int CountMat;
        public List<Material> Materials { get; set; } = new();
		public List<Details> Details { get; set; } = new();
		public List<Models.Type> Types { get; set; } = new();
		public List<Manufacturer> Manufacturers { get; set; } = new();
		public StatisticModel(ApplicationContext db)
		{
			context = db;

		}
		public void OnGet()
        {
			Materials = context.Materials.ToList();
								
			Details = context.Details.ToList();
			Types = context.Types.ToList();	
			Manufacturers = context.Manufacturers.ToList();
		}
    }
}
