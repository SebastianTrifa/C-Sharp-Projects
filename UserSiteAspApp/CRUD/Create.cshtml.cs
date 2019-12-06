using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project_WebPage.Models;

namespace Project_WebPage.CRUD
{
    public class CreateModel : PageModel
    {
        private readonly Project_WebPage.Models.SpartaModel _context;

        public CreateModel(Project_WebPage.Models.SpartaModel context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Users Users { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Users.Add(Users);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}