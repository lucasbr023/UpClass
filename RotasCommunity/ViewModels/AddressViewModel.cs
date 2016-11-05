using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UpClass.ViewModels
{
    public class AddressViewModel
    {
        [Required]
        public string CEP { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Logradouro { get; set; }
        public string Complemento { get; set; }

    }
}