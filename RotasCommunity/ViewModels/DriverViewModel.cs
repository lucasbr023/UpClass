using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UpClass.ViewModels
{
    public class DriverViewModel
    {
        public int DriverID { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Email { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Categoria { get; set; }
        public AddressViewModel Endereco { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public string RG { get; set; }
        [Required]
        public string CNH { get; set; }
        [Required]
        [DisplayName("Categoria CNH")]
        public string CategoriaCNH { get; set; }
        [Required]
        [DisplayName("Titulo de eleitor")]
        public string TituloEleitor { get; set; }
        [Required]
        public DateTime Nascimento { get; set; }
        [Required]
        public string Naturalidade { get; set; }
        [Required]
        [DisplayName("Quantidade de serviços")]
        public int QtdServicos { get; set; }
        

    }
}