using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Model.Jeux_Models
{
    public class Jeux_Model
    {
        public int Id { get; }
        public string Title { get; set; }
        public DateTime DateSortie { get; set; }
        public int Note { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
    }
}
