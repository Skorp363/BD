using BD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BD.Pages
{
	[IgnoreAntiforgeryToken]
	public class AddModel : PageModel
	{
		private readonly ApplicationContext context;
		public List<string> Message { get; set; } = new();
		public List<Material> Materials { get; private set; } = new();
		public List<Manufacturer> Manufacturers { get; private set; } = new();
		public List<Models.Type> Types { get; private set; } = new();
		public List<Country> Country { get; private set; } = new();
		public List<Details> Details { get; private set; } = new();
		[BindProperty]
		public Details Detail { get; set; } = new();
		//public Country Countries { get; private set; } = new();
		public AddModel(ApplicationContext db)
		{
			context = db;
		}

		public async Task OnGetAsync()
		{
			/*Details = await context.Details
				.Include(x => x.Country)
				.Include(x => x.Manufacturer)
				.Include(x => x.Material)
				.Include(x => x.Part_type)
				.OrderBy(x => x.Id)
				.ToListAsync();*/

			Materials = await context.Materials.OrderBy(m => m.Name).ToListAsync();
			Manufacturers = await context.Manufacturers.OrderBy(m => m.Name).ToListAsync();
			Types = await context.Types.OrderBy(t => t.Name).ToListAsync();
			Country = await context.Countries.OrderBy(c => c.Name).ToListAsync();
		}

		public async Task<IActionResult> OnPostAsync()
		{
			/*Details = await context.Details
				.Include(x => x.Country)
				.Include(x => x.Manufacturer)
				.Include(x => x.Material)
				.Include(x => x.Part_type)
				.OrderBy (x => x.Id)
				.ToListAsync();*/

			Materials = await context.Materials.OrderBy(m=>m.Name).ToListAsync();
			Manufacturers = await context.Manufacturers.OrderBy(m=>m.Name).ToListAsync();
			Types = await context.Types.OrderBy(t => t.Name).ToListAsync();
			Country = await context.Countries.OrderBy(c => c.Name).ToListAsync();


			if (Detail.Operating_voltage < 0 || Detail.Capacity < 0 || Detail.Power < 0 || Detail.Resistance < 0 || Detail.Electric_current < 0 || Detail.Inductance < 0 || Detail.Price < 0)
			{
				if (Message.Count > 0)
				{
					Message.RemoveAt(0);
				}
				Message.Add("Incorrect data!");
				return Page();
			}
			else if (Detail.MinOperating_Temp > Detail.MaxOperating_Temp)
			{
				if (Message.Count  > 0) 
				{ 
					Message.RemoveAt(0);
				}
				Message.Add("Incorrect min/max temperature values ​​entered!");
				return Page();	
			}
			
			else
			{
				if (Message.Count > 0)
				{
					Message.RemoveAt(0);
				}
				Message.Add("Part added successfully!");
				context.Details.Add(Detail);
				await context.SaveChangesAsync();
				return Page();
			}

		}

	}
}
