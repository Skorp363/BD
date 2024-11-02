using BD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BD.Pages
{
	[IgnoreAntiforgeryToken]
	public class AddManufacturerModel : PageModel
	{
		private readonly ApplicationContext context;
		public List<string> Message { get; set; } = new();
		public List<Manufacturer> Manufacturers { get; set; } = new();
		public List<Country> Countries { get; set; } = new();
		[BindProperty]
		public Manufacturer Manufacturer { get; set; } = new();
		public AddManufacturerModel(ApplicationContext db)
		{
			context = db;
		}

		public void OnGet()
		{
			Manufacturers = context.Manufacturers.AsNoTracking().ToList();
			Countries = context.Countries.OrderBy(c=>c.Name).ToList();
		}

		public async Task<IActionResult> OnPostAsync(string Name)
		{
			Manufacturers = await context.Manufacturers.AsNoTracking().ToListAsync();
			Countries = await context.Countries.OrderBy(c => c.Name).ToListAsync();
			var manufacturer = Manufacturers.FindAll(m=>m.Name == Name);
			Message.Clear();
			if (manufacturer.Count == 0)
			{
				Message.Add("Manufacturer added!");
				context.Manufacturers.Add(Manufacturer);
				await context.SaveChangesAsync();
				return Page();
			}
			else
			{
				Message.Add("The manufacturer is already in the database!");
				return Page();
				
			}
		}
	}
}
