using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Entities.DTO
{
    public class CoinsDTO
    {
        public int Id { get; set; }
        public string Denominacion { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
    }
}
