using System.Data.Entity;
namespace AppiSeccureStudent.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<AppiSeccureStudent.Models.Student> Students { get; set; }
    }
}