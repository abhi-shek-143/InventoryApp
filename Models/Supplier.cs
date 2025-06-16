using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Models
{
    public class Supplier
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string ContactInfo { get; set; }
    }
}
