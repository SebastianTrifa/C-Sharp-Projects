using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project_WebPage.Models;

namespace Project_WebPage.CRUD
{
    public class IndexModel : PageModel
    {
        private readonly Project_WebPage.Models.SpartaModel _context;

        public IndexModel(Project_WebPage.Models.SpartaModel context)
        {
            _context = context;
        }

        public IList<Users> Users { get;set; }

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }
    }
}
