using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDApplication.Models;

namespace CRUDApplication.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly CRUDApplication.Models.AppDbContext _context;

        public IndexModel(CRUDApplication.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
