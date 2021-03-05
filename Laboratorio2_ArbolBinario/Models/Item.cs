using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace Laboratorio2_ArbolBinario.Models
{
    public class Item
    {
        [Name("id")]
        public int Id { get; set; }
        [Name("nombre")]
        public string Nombre { get; set; }
        [Name("descripcion")]
        public string Descripcion { get; set; }
        [Name("casa_productora")]
        public string CasaProductora { get; set; }

        [Name("precio")]
        public string Price { get; set; }

        [Name("existencia")]
        public int Existencia { get; set; }
    }
}
