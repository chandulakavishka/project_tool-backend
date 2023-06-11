﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMT_backend.Services.Model
{
    public class EditComment
    {
        public int id { get; set; }
        [Required]
        public string Body { get; set; } = string.Empty;
    }
}
