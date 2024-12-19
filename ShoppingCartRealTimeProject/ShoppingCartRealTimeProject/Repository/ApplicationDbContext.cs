using Microsoft.EntityFrameworkCore;

namespace ShoppingCartRealTimeProject.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 

        {

        }
        
       
    }
}
