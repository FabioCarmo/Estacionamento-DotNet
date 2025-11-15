using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEstacionamento.Models
{
    public class Estacionamento {

        // Algumas propriedades uteis com validacao para valor nulo
        private decimal _precoInicial;
        private decimal _precoPorHora;
        private decimal _precoFinal;

        public decimal PrecoInicial {
            get => _precoInicial;
            set {
                if (value == 0) {
                    throw new Exception("Valor vazio !");
                }
                _precoInicial = value;
            }
        }

        public decimal PrecoPorHora {
            get => _precoPorHora;
            set {
                if (value == 0) {
                    throw new Exception("Valor vazio !");
                }
                _precoPorHora = value;
            }
        }

        public decimal PrecoFinal {
            get => _precoFinal;
            set {
                if (value == 0) {
                    throw new Exception("Valor Vazio !");
                }
                _precoFinal = value;
            }
        }

        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora) {
            this.PrecoInicial = precoInicial;
            this.PrecoPorHora = precoPorHora;
        }

        // Valida e formata a string de entrada
        public bool ValidarPlaca(string placa) {
            if (string.IsNullOrEmpty(placa)) {
                return false;
            }

            if (placa.Length > 8) {
                return false;
            }

            placa = placa.ToLower().Trim(); // Letras pequenas e remove espacos
            return true;
        }

        // Calcula o preco-hora do veiculo estacionado
        public decimal PrecoHora(double tempo) {
            this.PrecoFinal = (this.PrecoPorHora * Convert.ToDecimal(tempo)) + this.PrecoInicial;
            return Math.Round(this.PrecoFinal, 2);
        }

        // Realiza o cadastro do veiculo
        // Adiciona placa a lista veiculos
        public void CadastrarVeiculo(string placa) {
            if (! this.ValidarPlaca(placa)) {
                Console.WriteLine("Placa Invalida !");
                return;
            }

            if (this.veiculos.Contains(placa)) {
                Console.WriteLine("Esse veiculo ja esta cadastrado !");
                return;
            }

            this.veiculos.Add(placa);
            Console.WriteLine("Veiculo cadastrado com sucesso !");

            return;
        }

        // Realiza a remocao do veiculo
        // Remove a placa da lista veiculo
        public void RemoverVeiculo(string placa, double tempo) {
            if (! this.ValidarPlaca(placa)) {
                Console.WriteLine("Placa Invalida !");
                return;
            }

            if (this.veiculos.Count == 0 && ! this.veiculos.Contains(placa)) {
                Console.WriteLine("Nao existe veiculos cadastrados !");
                return;
            }

            decimal valor = this.PrecoHora(tempo);
            this.veiculos.Remove(placa);
            Console.WriteLine($"\tVeiculo {placa} - Removido! \n\tValor Total: R${valor}");

            return;
        }

        // Realiza a listagem dos veiculos
        // Retorna os valores da lista veiculo
        public void ListarVeiculo() {
            if (this.veiculos.Count == 0) {
                Console.WriteLine("Nao existe veiculos cadastrados !");
                return;
            }

            string lista = "\nLista de veiculos: "; 
            for (int ind = 0; ind < this.veiculos.Count; ind++) {
                lista += $"\n{ind+1} - Veiculo: {this.veiculos[ind]}";
            }
            
            Console.WriteLine(lista, "\n");
            return;
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