﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazaPerros.Models.ViewModels
{
    public class InfoPerroViewModel
    {
        public Razas Raza { get; set; }
        public IEnumerable<RazaViewModel> OtrasRazas { get; set; }
    }
}
