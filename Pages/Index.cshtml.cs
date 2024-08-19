using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExamenApp.Data;
using ExamenApp.Models;

namespace ExamenApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Estudiante> Estudiantes { get; set; } // Verifica que esta línea esté presente

        public async Task OnGetAsync()
        {
            Estudiantes = await _context.Estudiantes.ToListAsync();
        }
    }
}