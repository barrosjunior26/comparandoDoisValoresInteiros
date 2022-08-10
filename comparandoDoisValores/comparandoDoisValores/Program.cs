namespace comparandoDoisValoresInteiros
{
    class Exercicio26
    {
        public static void Main(String[] args)
        {
            /*26) Escreva um algoritmo que leia dois números inteiros e compare-os, mostrando
            na tela uma das mensagens abaixo:
            -O primeiro valor é o maior
            - O segundo valor é o maior
            - Não existe valor maior, os dois são iguais*/

            //Declaração de variáveis
            int escolha = 0;

            do
            {
                //Solicitando ao usuário a entrada dos dados
                Console.WriteLine("COMPARANDO DOIS VALORES INTEIROS\n");
                Console.Write("Informe o primeiro valores: ");
                int valor1 = int.Parse(Console.ReadLine());
                Console.Write("Informe o segundo valor: ");
                int valor2 = int.Parse(Console.ReadLine());

                //Processamento e comparação dos dados que o usuário forneceu
                if (valor1 > valor2)
                {
                    Console.WriteLine("O primeiro valor é o maior");
                }
                else if (valor2 > valor1)
                {
                    Console.WriteLine("O segundo valor é o maior");
                }
                else { Console.WriteLine("Não existe valor maior, os dois são iguais"); }
                //
                //Solicitando se o usuário deseja realizar uma nova operação ou encerrar o sistema.
                Console.Write("\n1 - NOVA OPERAÇÃO ou 0 - SAIR DO SISTEMA: ");
                escolha = int.Parse(Console.ReadLine());
            }while (escolha != 0);
        }
    }
}