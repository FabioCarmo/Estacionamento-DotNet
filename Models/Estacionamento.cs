using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEstacionamento.Models
{
    public class Estacionamento {

        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora) {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void CadastrarVeiculo(string placa) {

        }

        public void RemoverVeiculo(string placa) {

        }

        public void ListarVeiculo(string placa) {

        }

        public void PrecoHora(double tempo) {

        }
        
    }
}