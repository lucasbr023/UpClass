using System;

namespace Entidades
{
    public class CNH
    {

        public string Documento { get; set; }
        public DateTime Validation_cnh { get; set; }
        public string Category { get; set; }
        public string Prontuario { get; set; }
        public DateTime Emissao { get; set; }
        public string LocalEmissao { get; set; }

    }
}