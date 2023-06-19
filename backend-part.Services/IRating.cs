using backend_part.Models;
using backend_part.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Services
{
    public interface IRating
    {
        public void AddRating(RatingModel rating);
        public void UpdateRating(RatingModel rating);
    }
}
