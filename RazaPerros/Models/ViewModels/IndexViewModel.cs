﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazaPerros.Models.ViewModels
{
    public class IndexViewModel
    {
        
            public IEnumerable<char> LetrasIniciales { get; set; }
            public IEnumerable<RazaViewModel> Razas { get; set; }
        
    }
}
