namespace Repository.Data
{
    public class DbContext
    {
        private DbContextOptions<DNAContext> options;

        public DbContext(DbContextOptions<DNAContext> options)
        {
            this.options = options;
        }
    }
}