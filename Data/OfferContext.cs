
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class OfferContext: DbContext
    {
        public OfferContext(DbContextOptions<OfferContext> options)
            : base(options)
        {
        }

        public DbSet<Offers> Offers { get; set; }
    }
}
