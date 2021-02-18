using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingPlanner.Data.Entities;

namespace WeddingPlanner.Services.Interfaces
{
    public interface IPlanService
    {
        public List<Plan> GetAllPlans();
    }
}
