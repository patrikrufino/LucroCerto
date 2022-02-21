using System;

namespace LucroCerto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BEM-VINDO AO PROGRAMA PREÇO CERTO!\n\n");

            Produto[] produtos = new Produto[5];
            var indiceProduto = 0;

            string opcaoUsuario = ObterOpcaoMenu();

            while (opcaoUsuario.ToUpper() != "Q")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODDO - Criar adição de um novo produto
                        Console.WriteLine("Informe o nome do produto: ");
                        Produto produto = new Produto();
                        produto.Nome = Console.ReadLine();

                        Console.WriteLine("Informe o valor do produto: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal valor))
                        {
                            produto.Valor = valor;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal!");
                        }

                        Console.WriteLine("Informe a porcentagem de lucro desejada do produto: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal lucro))
                        {
                            produto.LucroDesejado = lucro;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal!");
                        }

                        produtos[indiceProduto] = produto;
                        indiceProduto++;

                        break;
                    case "2":
                        //TODDO - Criar listagem dos produtos criados
                        foreach (var elemento in produtos)
                        {
                            if (!string.IsNullOrEmpty(elemento.Nome))
                            {
                                Console.WriteLine($"PRODUTO: {elemento.Nome} | PREÇO DE CUSTO: R$ {elemento.Valor:0.00} | LUCRO DESEJADO: {elemento.LucroDesejado:0.00}%");
                            }
                        }
                        break;
                    case "3":
                        //TODDO - Criar calculo dos produtos
                        foreach (var elemento in produtos)
                        {
                            if (!string.IsNullOrEmpty(elemento.Nome))
                            {
                                Console.WriteLine($"PRODUTO: {elemento.Nome} | VALOR COM LUCRO: R$ {elemento.CalculaValorComLucro(elemento.Valor, elemento.LucroDesejado):0.00}");
                            }
                        }
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoMenu();
            }

        }

        private static string ObterOpcaoMenu()
        {
            Console.WriteLine("Digite a opção desejada:\n");
            Console.WriteLine("1 - Para adicionar um novo produto");
            Console.WriteLine("2 - Para listar todos os produtos");
            Console.WriteLine("3 - Para calcular o preço de venda dos produtos");
            Console.WriteLine("Q - Para sair do programa\n");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}
