using backend_part.Data;
using backend_part.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Services
{
    public class RatingService: IRating
    {
        private readonly DataContext _dBAccess = new DataContext();

        public void AddRating(RatingModel rating)
        {
            try
            {
                _dBAccess.Add(rating);
                _dBAccess.SaveChanges();
            }
            catch (Exception EX)
            {
                EX.ToString();
            }
        }

        public void UpdateRating(RatingModel rating)
        {
            var rating_ = _dBAccess.Rating.First(a => a.RateId == rating.RateId);
            rating_.Rate = rating.Rate;
            _dBAccess.SaveChanges();
        }


    }
}
