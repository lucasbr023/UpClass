using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UpClass.ViewModels
{
    public class RotaViewModel
    {

        public int RotaID { get; set; }
        [Required]
        public string Origem { get; set; }
        [Required]
        public string Destino { get; set; }
        [Required]
        [DisplayName("Data operação")]
        public DateTime DataOperacao { get; set; }
        [Required]
        [DisplayName("Data entrega")]
        public DateTime DataEntrega { get; set; }
        public bool Disponibilidade { get; set; }

    }
}