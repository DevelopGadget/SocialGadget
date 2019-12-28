using Microsoft.EntityFrameworkCore;

namespace Backend.Models
{
    public class DBContextApp : DbContext
    {
        protected DBContextApp(DbContextOptions options) : base (options) { }

    }
}