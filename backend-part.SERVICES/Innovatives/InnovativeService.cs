using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend_part.MODELS;

namespace backend_part.SERVICES.Innovatives
{
    public class InnovativeService : IInnovativeRepository
    {
        public List<Innovative> AllInnovatives()
        {
            var innovatives = new List<Innovative>();

            var innovative1 = new Innovative
            {
                InnovativeId = 1,
                InnovativeName = "A",
                Description = "ABCD",
                LeadId  = "Saman",
                EvaluatorId = "Kasun",
                StartDate = DateTime.Now,
            };
            innovatives.Add(innovative1);

            var innovative2 = new Innovative
            {
                InnovativeId = 2,
                InnovativeName = "B",
                Description = "PQRS",
                LeadId = "Nimal",
                EvaluatorId = "Supun",
                StartDate = DateTime.Now,
           

            };
            innovatives.Add(innovative2);
            var innovative3 = new Innovative
            {
                InnovativeId = 3,
                InnovativeName = "C",
                Description = "XYZ",
                LeadId = "Amal",
                EvaluatorId = "Saranga",
                StartDate = DateTime.Now,
            };
            innovatives.Add(innovative3);

            return innovatives;
        }
    }
}
