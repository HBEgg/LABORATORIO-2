using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio2_ArbolBinario.Models
{
    public class DataTableResponse
    {
        public int Draw { get; set; }
        public int RecordsTotal { get; set; }
        public int RecordsFiltered { get; set; }
        public List<Item> Data { get; set; } = new List<Item>();
    }
}
