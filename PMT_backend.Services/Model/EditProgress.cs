﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMT_backend.Services.Model
{
    public class EditProgress
    {
        [Required]
        public int id { get; set; }
        public int Prograss { get; set; }
    }
}
