using Microsoft.Data.Entity;

namespace PipeCI.Experiment.Models
{
    public interface IExperimentDbContext
    {
        DbSet<Experiment> Experiments { get; set; }
        int SaveChanges();
    }
}
