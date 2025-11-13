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

        public void ListarVeiculo() {

        }

        public void PrecoHora(double tempo) {

        }

        public string ExibirMenu() {
            string texto =  "Sistema de Estacionamento\n" +
                            "1 - Cadastrar Veiculo\n" +
                            "2 - Remover Veiculo\n" +
                            "3 - Listar Veiculos\n" +
                            "0 - Sair";
            return texto;
        }
        
    }
}