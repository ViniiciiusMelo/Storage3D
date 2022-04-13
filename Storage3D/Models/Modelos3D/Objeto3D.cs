using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage3D.Models.Modelos3D
{
    public class Objeto3D
    {
        public int Id { get; set; }
        
        public string Name { get;set;}

        public string Tipo { get; set; }

        public Models3D Class { get; set; }
    }
}
