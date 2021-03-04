using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio2_ArbolBinario.Models;

namespace Laboratorio2_ArbolBinario.Services
{
    public interface ISingleton
    {
        List<Item> DataSource { get; set; }
        ABdBNodo<IndexModel> IndexTree { get; set; }
    }
}
