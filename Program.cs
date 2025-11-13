
using DesafioEstacionamento.Models;

decimal preco_hora = 0;
decimal preco_inicial = 0;
bool programa = true;
int opcao;
string placa;

Console.WriteLine("Bem-vindo ao sistema de estacionamento!");
do {
    Console.WriteLine("Digite o Preco de Entrada para Estacionar: ");
    preco_inicial = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Agora Digite o Preco Hora para Estacionar: ");
    preco_hora = Convert.ToDecimal(Console.ReadLine());
} while (preco_inicial <= 0 && preco_hora <= 0);

Estacionamento est = new Estacionamento(preco_inicial, preco_hora); // Instancia o objeto

while (programa) {
    Console.WriteLine(est.ExibirMenu());
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao) {
        case 0:
            Console.WriteLine("Saindo...");
            programa = false;
            break;
        case 1:
            Console.WriteLine("Digite a placa do veiculo: ");
            placa = Console.ReadLine();
            est.CadastrarVeiculo(placa);
            break;
        case 2:
            Console.WriteLine("Digite a placa do veiculo: ");
            placa = Console.ReadLine();
            est.RemoverVeiculo(placa);
            break;
        case 3:
            est.ListarVeiculo();
            break;
        default:
            Console.WriteLine("Opcao Invalida !");
            break;
    }
}

// Inicio:
// 1 - Preco Inicial
// 2 - Preco Por Hora

// Menu:
// 1 - Cadastrar veículo (Placa)
// 2 - Remover veículo (Placa)
// 3 - Listar veículos (Placa)
// 4 - Sair