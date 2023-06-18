using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend_part.MODELS;

namespace backend_part.SERVICES.Innovatives
{
    public class InnovativeSqlService : IInnovativeRepository
    {
        private readonly DbAccess _context = new DbAccess();
        public List<Innovative> AllInnovatives()
        {
            var Users = _context.Innovatives.ToList();

            return Users;
        }
        
    }
}
