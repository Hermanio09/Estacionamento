using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Models
{
    public class Estacionamento
    {
        private decimal valorInicial= 0;
        private decimal valorPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal valorInicial, decimal valorPorHora0)
        {
            this.valorInicial = valorInicial;
            this.valorPorHora = valorPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo");
            veiculos.Add(Console.ReadLine());

        }
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veiculos estacionados sao:");
                int count = 1;
                
                foreach (string veic in veiculos)
                {
                    Console.WriteLine($"{count} veiculos: {veic}");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("Nao ha veiculos estacionados");
            }

        }

        public void RemoverVeiculos()
        {
            Console.WriteLine("Digite a placa do eiculo que voce deseja remover");

            string placa = "";

            placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horasPermanecidas = 0;
                decimal valorTotal = 0;

                Console.WriteLine("Digite a quantidade de horas");
                horasPermanecidas = Convert.ToInt32(Console.ReadLine());
                valorTotal = this.valorInicial + this.valorPorHora * horasPermanecidas;
                veiculos.Remove(placa);

                Console.WriteLine($"Oveiculo {placa} foi removido e o preco total foi de: R$ {valorTotal}");
            }
        }

    }

}