using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEstacionamento.Models
{
    public class Estacionamento {

        private decimal precoInicial;
        private decimal precoPorHora;
        private decimal precoFinal;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora) {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public bool ValidarPlaca(string placa) {
            if (string.IsNullOrEmpty(placa)) {
                return false;
            }

            placa = placa.ToLower().Trim(); // Letras pequenas e remove espacos
            return true;
        }

        // Calcula o preco-hora do veiculo estacionado
        public decimal PrecoHora(double tempo) {
            this.precoFinal = (this.precoPorHora * Convert.ToDecimal(tempo)) + this.precoInicial;
            return Math.Round(this.precoFinal, 2);
        }

        // Realiza o cadastro do veiculo
        // Adiciona placa a lista veiculos
        public string CadastrarVeiculo(string placa) {
            if (! this.ValidarPlaca(placa)) {
                return "Placa Invalida !";
            }

            if (this.veiculos.Contains(placa)) {
                return "Esse veiculo ja esta cadastrado !";
            }

            this.veiculos.Add(placa);
            return "Veiculo cadastrado com sucesso !";
        }

        // Realiza a remocao do veiculo
        // Remove a placa da lista veiculo
        public string RemoverVeiculo(string placa, double tempo) {
            if (! this.ValidarPlaca(placa)) {
                return "Placa Invalida !";
            }

            if (this.veiculos.Count == 0 && ! this.veiculos.Contains(placa)) {
                return "Nao existe veiculos cadastrados !";
            }

            decimal valor = this.PrecoHora(tempo);
            this.veiculos.Remove(placa);
            return $"\tVeiculo Removido! Tempo Estacionado: R${valor}";
        }

        // Realiza a listagem dos veiculos
        // Retorna os valores da lista veiculo
        public string ListarVeiculo() {
            if (this.veiculos.Count == 0) {
                return "Nao existe veiculos cadastrados !";
            }

            string lista = ""; 
            for (int ind = 0; ind < this.veiculos.Count; ind++) {
                lista += $"\t\n{ind+1} - Veiculo: {this.veiculos[ind]}";
            }

            return lista;
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