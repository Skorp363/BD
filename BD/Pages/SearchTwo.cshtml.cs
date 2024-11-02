using BD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BD.Pages
{
	[IgnoreAntiforgeryToken]
	public class SearchTwoModel : PageModel
	{
		private readonly ApplicationContext context;

		public List<Details> Details { get; set; } = new();

		public List<Details> DetailSearch { get; set; } = new();

		public List<Details> AllDetailSearch { get; set; } = new();

		//public List<Country> Countries { get; set; } = new();
		public List<Manufacturer> Manufacturers { get; set; } = new();

		public List<string> Names { get; set; } = new();

		public int ManId = 0;

		public SearchTwoModel(ApplicationContext db)
		{
			context = db;

		}


		public async Task OnGetAsync()
		{
			Details = await context.Details
			   .Include(x => x.Country)
			   .Include(x => x.Manufacturer)
			   .Include(x => x.Material)
			   .Include(x => x.Part_type)
			   .ToListAsync();
			//Countries = Details.Select(x => x.Country).Distinct().OrderBy(c => c.Name).ToList();
			Manufacturers = Details.Select(x => x.Manufacturer).Distinct().OrderBy(m => m.Name).ToList();
		}

		public async Task OnPostFirst(int ManufacturerId)
		{
			ManId = ManufacturerId;
			Details = await context.Details
			   .Include(x => x.Country)
			   .Include(x => x.Manufacturer)
			   .Include(x => x.Material)
			   .Include(x => x.Part_type)
			   .ToListAsync();
			//Countries = Details.Select(x => x.Country).Distinct().OrderBy(c => c.Name).ToList();
			Manufacturers = Details.Select(x => x.Manufacturer).Distinct().OrderBy(m => m.Name).ToList();


			DetailSearch = Details.FindAll(d => d.ManufacturerId == ManufacturerId).OrderBy(m => m.Name).ToList();

			Names = DetailSearch.Select(x => x.Name).Distinct().ToList();
		}

		public async Task OnPostSecond(int NameId, string Name)
		{
			ManId = NameId;

			Details = await context.Details
			   .Include(x => x.Country)
			   .Include(x => x.Manufacturer)
			   .Include(x => x.Material)
			   .Include(x => x.Part_type)
			   .ToListAsync();
			//Countries = Details.Select(x => x.Country).Distinct().OrderBy(c => c.Name).ToList();
			Manufacturers = Details.Select(x => x.Manufacturer).Distinct().OrderBy(m => m.Name).ToList();

			AllDetailSearch = Details.FindAll(d => d.ManufacturerId == NameId).OrderBy(m => m.Name).ToList();

			DetailSearch = Details.FindAll(d => (d.Name == Name) && (d.ManufacturerId == NameId));

			Names = AllDetailSearch.Select(x => x.Name).Distinct().ToList();

		}
	}
}

