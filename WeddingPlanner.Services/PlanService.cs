using System.Collections.Generic;
using System.Linq;
using WeddingPlanner.Data.Entities;
using WeddingPlanner.Data.Repository;
using WeddingPlanner.Services.Interfaces;

namespace WeddingPlanner.Services
{
    public class PlanService : IPlanService
    {
        private DataContext _context;

        public PlanService(DataContext context)
        {
            _context = context;
        }
        public List<Plan> GetAllPlans()
        {
            return _context.Plan.ToList();
        }
    }
}
