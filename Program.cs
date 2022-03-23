using System;

namespace Lista2deExercicios
{
    class Program
    {
        static void Main(string[] args) {
            Lista l1 = new Lista();

            l1.InsereFim(8);
            l1.InsereFim(10);
            l1.InsereFim(5);
            l1.InsereFim(3);
            l1.InsereFim(7);
            int aux = 1;
            while (aux != 0) {
                Console.WriteLine();
                Console.WriteLine("Escolha uma opçao do menu:");
                Console.WriteLine(" [1] - Insere um elemento na lista");
                Console.WriteLine(" [2] - Insere um elemento apos outro selecionado na lista");
                Console.WriteLine(" [3] - Determina o maior elemento da lista");
                Console.WriteLine(" [4] - Remover um elemento da lista");
                Console.WriteLine(" [5] - Imprime a lista");
                Console.WriteLine(" [6] - Sair");

                String op = Console.ReadLine();
                switch (op) {
                    case "1":
                        Console.WriteLine("Digite o elemento a ser inserido na lista: ");
                        int elemento1 = Convert.ToInt32(Console.ReadLine());
                        l1.InsereInicio(elemento1);
                        break;
                    case "2":
                        Console.WriteLine("Digite apos qual elemento o e qual o novo valor a ser inserido: ");
                        int elemento2 = Convert.ToInt32(Console.ReadLine());
                        int elemento3 = Convert.ToInt32(Console.ReadLine());
                        l1.InsereApos(elemento2, elemento3);
                        break;
                    case "3":
                        Console.WriteLine("O maior elemento da lista eh o " + l1.MaiorLista());
                        
                        break;
                    case "4":
                        Console.WriteLine("Digite o elemento a ser removido da lista: ");
                        int elemento4 = Convert.ToInt32(Console.ReadLine());
                        l1.Remove(elemento4);
                        break;
                    case "5":
                        Console.WriteLine();
                        l1.ImprimeDireitaEsq();
                        break;
                    case "6":
                        aux = 0;
                        break;
                }
            }
        }
    }
}
