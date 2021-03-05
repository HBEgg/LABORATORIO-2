using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio2_ArbolBinario.Models;

namespace Laboratorio2_ArbolBinario.Services
{
    public class Singleton : ISingleton
    {
        public List<Item> DataSource { get; set; } = new List<Item>();
        public TreeNode<IndexModel> IndexTree { get; set; }
        public Singleton()
        {

        }
    }
}
