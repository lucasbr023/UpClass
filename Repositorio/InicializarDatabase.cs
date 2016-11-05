using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class InicializarDatabase : DropCreateDatabaseIfModelChanges<Context>
    {

        protected override void Seed(Context context)
        {
            //Endereco e = new Endereco() { Estado = "PE", Bairro = "Cordeiro", Cep = "50630-650", Cidade = "Recife", Logradouro = "Rua ...", Numero = "914", Complemento = "" };

            //Cliente c = new Cliente() { Nome = "Lucas", Endereco = e, DataNascimento = DateTime.Now, Documento = "10758480407" };

            //Carro carro = new Carro() { Ano = "2011", Placa = "PEN-4655", Chassi = "123", Cor = "preto", QtdPortas = 2, Quilometragem = 1, Status = false };

            //Fabricante FabricanteHyundai = new Fabricante() { Nome = "Hyundai" };
            //Fabricante FabricanteVolkswagen = new Fabricante() { Nome = "Volkswagen" };
            //Fabricante FabricanteFord = new Fabricante() { Nome = "Ford" };
            //Fabricante FabricanteFiat = new Fabricante() { Nome = "Fiat" };
            //Fabricante FabricanteChevrolet = new Fabricante() { Nome = "Chevrolet " };
            //Fabricante FabricanteRenault = new Fabricante() { Nome = "Renault" };
            //Fabricante FabricanteToyota = new Fabricante() { Nome = "Toyota" };
            //Fabricante FabricanteHonda = new Fabricante() { Nome = "Honda " };

            //Modelo hb20 = new Modelo() { Nome = "HB20", Fabricante = FabricanteHyundai };
            //Modelo crossfox = new Modelo() { Nome = "Crossfox", Fabricante = FabricanteVolkswagen };
            //Modelo fordka = new Modelo() { Nome = "Ford KA", Fabricante = FabricanteFord };
            //Modelo fiesta = new Modelo() { Nome = "Fiesta", Fabricante = FabricanteFord };
            //Modelo palio = new Modelo() { Nome = "Palio", Fabricante = FabricanteFiat };
            //Modelo onix = new Modelo() { Nome = "Onix", Fabricante = FabricanteChevrolet };
            //Modelo strada = new Modelo() { Nome = "Strada", Fabricante = FabricanteFiat };
            //Modelo gol = new Modelo() { Nome = "Gol", Fabricante = FabricanteVolkswagen };
            //Modelo uno = new Modelo() { Nome = "Uno", Fabricante = FabricanteFiat };
            //Modelo fox = new Modelo() { Nome = "Fox", Fabricante = FabricanteVolkswagen };
            //Modelo sandero = new Modelo() { Nome = "Sandero", Fabricante = FabricanteRenault };
            //Modelo prisma = new Modelo() { Nome = "Prisma", Fabricante = FabricanteChevrolet };
            //Modelo corolla = new Modelo() { Nome = "Corolla", Fabricante = FabricanteToyota };
            //Modelo saveiro = new Modelo() { Nome = "Saveiro", Fabricante = FabricanteVolkswagen };
            //Modelo siena = new Modelo() { Nome = "Siena", Fabricante = FabricanteFiat };
            //Modelo fit = new Modelo() { Nome = "Fit", Fabricante = FabricanteHonda };

            //carro.Modelo = fordka;
            //context.Modelos.Add(hb20);
            //context.Modelos.Add(crossfox);
            //context.Modelos.Add(fordka);
            //context.Modelos.Add(fiesta);
            //context.Modelos.Add(palio);
            //context.Modelos.Add(onix);
            //context.Modelos.Add(strada);
            //context.Modelos.Add(gol);
            //context.Modelos.Add(uno);
            //context.Modelos.Add(fox);
            //context.Modelos.Add(sandero);
            //context.Modelos.Add(prisma);
            //context.Modelos.Add(corolla);
            //context.Modelos.Add(saveiro);
            //context.Modelos.Add(siena);
            //context.Modelos.Add(fit);
            //context.Fabricantes.Add(FabricanteHyundai);
            //context.Fabricantes.Add(FabricanteVolkswagen);
            //context.Fabricantes.Add(FabricanteFord);
            //context.Fabricantes.Add(FabricanteHonda);
            //context.Fabricantes.Add(FabricanteToyota);
            //context.Fabricantes.Add(FabricanteFiat);
            //context.Fabricantes.Add(FabricanteRenault);
            //context.Fabricantes.Add(FabricanteChevrolet);
            //context.Carros.Add(carro);
            //context.Clientes.Add(c);

            context.SaveChanges();

        }

    }
}
