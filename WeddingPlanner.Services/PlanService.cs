using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingPlanner.Data.Entities;
using WeddingPlanner.Data.Repository;

namespace WeddingPlanner.Services
{
    public class PlanService
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
