using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovies.Models;
using RazorPagesMovies.Movies;

namespace RazorPagesMovies.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovies.Models.MoviesContext _context;

        public IndexModel(RazorPagesMovies.Models.MoviesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
