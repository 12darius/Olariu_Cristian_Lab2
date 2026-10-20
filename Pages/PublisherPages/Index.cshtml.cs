using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Olariu_Cristian_Lab2.Models;

namespace Olariu_Cristian_Lab2.Pages.PublisherPages;

public class IndexModel : PageModel
{
    private readonly Olariu_Cristian_Lab2Context _context;

    public IndexModel(Olariu_Cristian_Lab2Context context)
    {
        _context = context;
    }

    public IList<Publisher> Publisher { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Publisher = await _context.Publisher
            .Include(p => p.Books)
            .ToListAsync();
    }
}
