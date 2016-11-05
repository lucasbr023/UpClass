using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Veiculo
{
    public class Veiculo
    { 
        [Key]
        public int VeiculoID { get; set; }
        public String Categoria { get; set; }
        public string Placa { get; set; }
        public string Renavan { get; set; }
        public string Chassi { get; set; }
        public string Modelo { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public DateTime AnoModelo { get; set; }
        public string Marca { get; set; }
        public virtual Driver Driver { get; set; }
        public int DriverID { get; set; }
    }
}
