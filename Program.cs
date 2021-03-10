using System;

namespace Morra_Cinese
{
    class Program
    {
        public static string mossa_giocatore1 = "";
        public static string mossa_giocatore2 = "";
        public static int Vittorie_giocatore1 = 0;
        public static int Vittorie_giocatore2 = 0;
        public static string Sasso = "Sasso";
        public static string Carta = "Carta";
        public static string Forbice = "Forbice";

        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel gioco della morra cinese");

            Console.WriteLine("\nInserisci il nome del giocatore 1");
            string nome_giocatore_1 = Console.ReadLine();

            Console.WriteLine("\nInserisci il nome del giocatore 2");
            string nome_giocatore_2 = Console.ReadLine();

            do
            {
                Console.Clear();

                Console.WriteLine($"Ora e' il turno del giocatore {nome_giocatore_1}");               
                Console.WriteLine("Scegli che se vuoi buttare sasso (digita S), forbice (digita D) o carta (digita A)");
                string Scelta_Giocatore_1 = Convert.ToString(Console.ReadKey(true).KeyChar);

                while (Scelta_Giocatore_1 != "S" && Scelta_Giocatore_1 != "D" && Scelta_Giocatore_1 != "A")
                {
                    Console.Clear();
                    Console.WriteLine("La risposta inserita non e' corretta...");
                    Console.WriteLine("Scegli che se vuoi buttare sasso (digita S), forbice (digita D) o carta (digita A)");
                    Scelta_Giocatore_1 = Convert.ToString(Console.ReadKey(true).KeyChar);                    
                }

                if (Scelta_Giocatore_1 == "S")
                {
                    mossa_giocatore1 = Sasso;
                }
                else if (Scelta_Giocatore_1 == "D")
                {
                    mossa_giocatore1 = Forbice;
                }
                else if (Scelta_Giocatore_1 == "A")
                {
                    mossa_giocatore1 = Carta;
                }

                Console.WriteLine($"\nOra e' il turno del giocatore {nome_giocatore_2}");
                Console.WriteLine("Scegli che se vuoi buttare sasso (digita K), forbice (digita L) o carta (digita J)");
                string Scelta_Giocatore_2 = Convert.ToString(Console.ReadKey(true).KeyChar);

                while (Scelta_Giocatore_2 != "K" && Scelta_Giocatore_2 != "L" && Scelta_Giocatore_2 != "J")
                {
                    Console.Clear();
                    Console.WriteLine("La risposta inserita non e' corretta...");
                    Console.WriteLine("Scegli che se vuoi buttare sasso (digita K), forbice (digita L) o carta (digita J)");
                    Scelta_Giocatore_2 = Convert.ToString(Console.ReadKey(true).KeyChar);                    
                }

                if (Scelta_Giocatore_2 == "K")
                {
                    mossa_giocatore2 = Sasso;
                }
                else if (Scelta_Giocatore_2 == "L")
                {
                    mossa_giocatore2 = Forbice;
                }
                else if (Scelta_Giocatore_2 == "J")
                {
                    mossa_giocatore2 = Carta;
                }


                if (mossa_giocatore1 == mossa_giocatore2)
                {
                    Console.WriteLine("\nPAREGGIO");
                }
                else if (mossa_giocatore1 == Sasso && mossa_giocatore2 == Forbice)
                {
                    Console.WriteLine($"\nHA VINTO IL GIOCATORE {nome_giocatore_1}");
                    Vittorie_giocatore1++;
                }
                else if (mossa_giocatore1 == Sasso && mossa_giocatore2 == Carta)
                {
                    Console.WriteLine($"\nHA VINTO IL GIOCATORE {nome_giocatore_2}");
                    Vittorie_giocatore2++;
                }
                else if (mossa_giocatore1 == Forbice && mossa_giocatore2 == Sasso)
                {
                    Console.WriteLine($"\nHA VINTO IL GIOCATORE {nome_giocatore_2}");
                    Vittorie_giocatore2++;
                }
                else if (mossa_giocatore1 == Forbice && mossa_giocatore2 == Carta)
                {
                    Console.WriteLine($"\nHA VINTO IL GIOCATORE {nome_giocatore_1}");
                    Vittorie_giocatore1++;
                }
                else if (mossa_giocatore1 == Carta && mossa_giocatore2 == Sasso)
                {
                    Console.WriteLine($"\nHA VINTO IL GIOCATORE {nome_giocatore_1}");
                    Vittorie_giocatore1++;
                }
                else if (mossa_giocatore1 == Carta && mossa_giocatore2 == Forbice)
                {
                    Console.WriteLine($"\nHA VINTO IL GIOCATORE {nome_giocatore_2}");
                    Vittorie_giocatore2++;
                }
                
                Console.WriteLine("\nPer continuare premere qualsiasi tasto, però se vuoi terminare il gioco, premi X");

            } while(Console.ReadKey().Key != ConsoleKey.X);

            Console.Clear();

            if (Vittorie_giocatore1 == Vittorie_giocatore2)
            {
                Console.WriteLine($"Il Giocatore {nome_giocatore_1} e il Giocatore {nome_giocatore_2} hanno pareggiato");
            }
            else if (Vittorie_giocatore1 > Vittorie_giocatore2)
            {
                Console.WriteLine($"Il Giocatore {nome_giocatore_1} ha vinto contro il Giocatore {nome_giocatore_2}");
            }
            else if (Vittorie_giocatore2 > Vittorie_giocatore1)
            {
                Console.WriteLine($"Il Giocatore {nome_giocatore_2} ha vinto contro il Giocatore {nome_giocatore_1}");
            }

            Console.WriteLine($"\nIl Giocatore {nome_giocatore_1} ha vinto n°: {Vittorie_giocatore1} , mentre il Giocatore {nome_giocatore_2} ha vinto n°: {Vittorie_giocatore2} ");
                     
            Console.ReadKey();
        }
    }
}
