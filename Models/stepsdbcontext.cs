using Microsoft.EntityFrameworkCore;

namespace health_and_fitness_app.Models
{
    public class stepsdbcontext :  DbContext
    {

        public stepsdbcontext(DbContextOptions<stepsdbcontext> options) : base(options)
        {
        }

        public  DbSet<stepsmodelcs> steps { get; set; }
    }
}
