﻿using System.Collections.Generic;

namespace MiNegocio.Models.Models
{
    public partial class Tbmarca
    {
        public Tbmarca()
        {
            Tbmodelo = new HashSet<Tbmodelo>();
        }

        public int IdMarca { get; set; }
        public string Marca { get; set; }

        public virtual ICollection<Tbmodelo> Tbmodelo { get; set; }
    }
}
