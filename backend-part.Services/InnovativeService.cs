using backend_part.Data;
using backend_part.Models;
using System.Collections.Generic;
using System.Linq;


namespace backend_part.Services
{
    public class InnovativeService:IInnovative
    {

        private readonly DataContext _dBAccess = new DataContext();

        public List<Innovative> GetInnovative(int id)
        {
         
            var innovative_ = _dBAccess.Innovatives.Where(innovative => innovative.ProjectId == id).ToList();
            return innovative_;
        }
    }
}
