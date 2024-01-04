using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management_ELHAFIDI.Data
{
    public class DataContext:IdentityDbContext
    {
        public DataContext(DbContextOptions options): base(options) { }
    }
}
