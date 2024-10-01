using BD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BD.Pages
{
	[IgnoreAntiforgeryToken]
	public class AddMaterialModel : PageModel
	{
		private readonly ApplicationContext context;
		public List<string> Message = new();
		public List<Material> Materials { get; set; } = new();

		[BindProperty]
		public Material Material { get; set; } = new();

		public AddMaterialModel(ApplicationContext db)
		{
			context = db;
		}

		public void OnGet()
		{
			Materials = context.Materials.AsNoTracking().ToList();
		}

		public async Task<IActionResult> OnPostAsync(string Name)
		{
			Materials = context.Materials.AsNoTracking().ToList();
			var material = Materials.Find(m=>m.Name == Name);
			if (material == null)
			{
				context.Materials.Add(Material);
				await context.SaveChangesAsync();
				return RedirectToPage();
			}
			else
			{
				Message.Add("The material is already in the database!");
				return Page();
			}
		}


	}
}
