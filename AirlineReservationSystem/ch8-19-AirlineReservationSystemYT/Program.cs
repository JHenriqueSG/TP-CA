using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    class Program
    {
        public class Destino
        {
            private static List<Destino> destinos;

            // Cria as rotas de destino
            public Destino(int numVoo, string rota)
            {
                destinos = new List<Destino>();
                Destino BH_Rio = new Destino(1, "BH/Rio");
                Destino BH_SP = new Destino(2, "BH/SP");
                Destino BH_Recife = new Destino(3, "BH/Recife");

                destinos.Add(BH_Rio);
                destinos.Add(BH_SP);
                destinos.Add(BH_Recife);
  
            }

        }
        static void Main(string[] args)
        {

            Console.Title = "UIAC - Unified International Air Companny";

            Console.Clear();
            preMenu();
            menu();
            Reserva();


        }
        public class Passageiro
        {

            public Passageiro()
            {
                this.CPF = CPF;
                this.nome = nome;
                this.sobrenome = sobrenome;
                this.endereco = endereco;
                this.telefone = telefone;
            }

            public int CPF { get; set; }
            public string nome { get; set; }
            public string sobrenome { get; set; }
            public string endereco { get; set; }
            public string telefone { get; set; }

        }

        static void Reserva()
        {
            List<Passageiro> passageiros = new List<Passageiro>();
            Passageiro passageiro = new Passageiro();
            {
                passageiro.CPF = Convert.ToInt32(Console.ReadLine());
                passageiro.nome = Console.ReadLine();
                passageiro.sobrenome = Console.ReadLine();
                passageiro.telefone = Console.ReadLine();
                passageiro.endereco = Console.ReadLine();

                while (passageiros.Count >= 5)
                {
                    passageiros.Add(new Passageiro());
                }

                for (int i = 0; i < passageiros.Count; i++)
                {
                    Console.WriteLine(passageiros[i].ToString());
                }
            }
        }

        static void menu()
        {
            Console.Title = "UIAC - Unified International Air Companny";
            Console.WriteLine("\n MENU");

            Console.WriteLine("\nopçoes para o Voo "    + DateTime.Now);

            Console.WriteLine("\n Digite a opção desejada: ");

            Console.WriteLine("\n1 - Lista de passageiros ");

            Console.WriteLine("\n2 - Pesquisar passageiros ");

            Console.WriteLine("\n3 - Cadastrar passageiros ");

            Console.WriteLine("\n4 - Excluir passageiros ");

            Console.WriteLine("\n5 - Fila de espera ");

            Console.WriteLine("\nESC - sair ");

            Console.Write("\n\n\n Digite a opção desejada: ");
            ConsoleKeyInfo cki;

            do
            {

                cki = Console.ReadKey(false); 
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        {
                            Reserva();
                            Console.WriteLine();
                                break;
                        }
                    case "2":
                        {
                            Console.WriteLine("insira o CPF:");
                            
                          
                            break;
                        }
                    case "3":
                        {
                            
                            
                            break;
                        }
                    case "4":
                        {

                            break;
                        }
                    case "5":
                        {
                            
                            break;
                        }
                    case "ESC":
                        {

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("opção invalida");
                            break;
                        }
                }
            } while (cki.Key != ConsoleKey.Escape);



            Console.ReadKey();

        }
        static void preMenu()
        {
            Console.Title = "UIAC - Unified International Air Companny";
            Console.WriteLine("\n MENU");

            Console.WriteLine("\nopçoes de Voo ");

            Console.WriteLine("\n Digite a opção desejada: ");

            Console.WriteLine("\n1 - Bh/Sp ");

            Console.WriteLine("\n2 - Bh/Rio ");

            Console.WriteLine("\n3 - Bh/Recife ");

            Console.WriteLine("\nESC - sair ");

            Console.Write("\n\n\n Digite a opção desejada: ");
            ConsoleKeyInfo cki;
            do
            {

                cki = Console.ReadKey(false);
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        {
                            Console.WriteLine("BH/SP" + DateTime.Now);
                            Console.Clear();
                            menu();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("BH/RIO" + DateTime.Now);
                            Console.Clear();
                            menu();
                            break;
                        }
                    case "3":
                        {

                            Console.WriteLine("BH/RECIFE" + DateTime.Now);
                            Console.Clear();
                            menu();
                            break;
                        }
                    case "ESC":
                        {
                            break;
                        }

                    default:
                        {

                            break;
                        }
                }
            } while (cki.Key != ConsoleKey.Escape);
        }
 
    }
    
}
