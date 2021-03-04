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
        [Name("name")]
        public string Name { get; set; }
        [Name("description")]
        public string Description { get; set; }
        [Name("production_house")]
        public string Production_House { get; set; }

        [Name("price")]
        public string Price { get; set; }

        [Name("existence")]
        public int Existence { get; set; }
    }
}
