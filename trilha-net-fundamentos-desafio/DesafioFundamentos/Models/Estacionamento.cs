namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaDoveiculo = Console.ReadLine();

            if (veiculos.Contains(placaDoveiculo))
            {
                Console.WriteLine("O Veículo já está estacionado");

            } else
            {
                veiculos.Add(placaDoveiculo);
                Console.WriteLine("Veículo estacionado com sucesso!");
            }

            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

             string placaDoveiculo = Console.ReadLine();
           

            if (veiculos.Any(x => x.ToUpper() == placaDoveiculo.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
           
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoInicial * horas); 

                veiculos.Remove(placaDoveiculo);

                Console.WriteLine($"O veículo {placaDoveiculo} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
