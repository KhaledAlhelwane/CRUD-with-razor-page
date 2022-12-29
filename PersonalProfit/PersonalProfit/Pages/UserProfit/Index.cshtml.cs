using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PersonalProfit.Data;
using PersonalProfit.Model;

namespace PersonalProfit.Pages.UserProfit
{
    public class IndexModel : PageModel
    {
        private readonly PersonalProfit.Data.PersonalProfitContext _context;

        public IndexModel(PersonalProfit.Data.PersonalProfitContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }
        public async Task OnGetAsync()
        {
            IQueryable<string> type = from m in _context.User
                                      orderby m
                                      select m.type;
            var movies = from m in _context.User
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Name.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.type == MovieGenre);
            }
            Genres = new SelectList(await type.Distinct().ToListAsync());
            User = await movies.ToListAsync();
        }
    }
}
