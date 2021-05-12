using Microsoft.EntityFrameworkCore;

namespace Web_Service.Models
{
    public class MoscowEducationalInstitutionsdbMainContext : DbContext
    {
        public MoscowEducationalInstitutionsdbMainContext()
        {
        }

        public DbSet<MoscowEducationalInstitutionInfo> MoscowEducationalInstitutions { get; set; }

        public MoscowEducationalInstitutionsdbMainContext(DbContextOptions<MoscowEducationalInstitutionsdbMainContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();           
        }
    }
}