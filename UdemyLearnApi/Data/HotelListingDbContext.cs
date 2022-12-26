using Microsoft.EntityFrameworkCore;

namespace UdemyLearnApi.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
