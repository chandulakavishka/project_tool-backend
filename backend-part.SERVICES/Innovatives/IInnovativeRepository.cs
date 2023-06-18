using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend_part.MODELS;

namespace backend_part.SERVICES.Innovatives
{
    public interface IInnovativeRepository
    {
        public List<Innovative> AllInnovatives();
    }
}
