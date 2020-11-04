﻿using System;
using System.Collections.Generic;

namespace RazaPerros.Models
{
    public partial class Paises
    {
        public Paises()
        {
            Razas = new HashSet<Razas>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Razas> Razas { get; set; }
    }
}
