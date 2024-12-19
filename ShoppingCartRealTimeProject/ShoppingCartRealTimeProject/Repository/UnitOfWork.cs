namespace ShoppingCartRealTimeProject.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        private ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
        }
        public void save()
        {
            _db.SaveChanges();
        }
        
    }
}
