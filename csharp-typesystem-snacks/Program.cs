using System;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
                bool control = true;
            {
                // Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.
                Console.WriteLine(Program.Prettifier("Snack 1"));
                int num1 = 0;
                int num2 = 0;
                while (control)
                {
                    try
                    {
                        Console.WriteLine("Inserisci il primo intero");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        control = false;
                    } catch (FormatException)
                    {
                        Console.WriteLine("ERRORE: Il valore inserito non è un numero");
                        control = true;
                    }
                }
                control = true;
                while (control)
                {
                    try
                    {
                        Console.WriteLine("Inserisci il secondo intero");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        control = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("ERRORE: Il valore inserito non è un numero");
                        control = true;
                    }
                }
                control = true;
                
                Console.WriteLine($"Il numero maggiore tra {num1} e {num2} è: {Math.Max(num1, num2)}");
            }

            Console.WriteLine();

            {
                // Snack 2: L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.
                Console.WriteLine(Program.Prettifier("Snack 2"));
                string word1 = "";
                string word2 = "";
                while (control)
                {
                    try
                    {
                        Console.WriteLine("Inserisci la prima parola");
                        word1 = Console.ReadLine();
                        control = false;
                    } catch (FormatException)
                    {
                        Console.WriteLine("ERRORE: Il valore inserito non è una stringa");
                        control = true;
                    }
                }
                control = true;
                while (control)
                {
                    try
                    {
                        Console.WriteLine("Inserisci la seconda parola");
                        word2 = Console.ReadLine();
                        control = false;
                    } catch (FormatException)
                    {
                        control = true;
                    }
                }
                control = true;
                if (word1.Length > word2.Length) Console.WriteLine($"La parola più corta è: {word2} e la parola più lunga è: {word1}");
                else if (word1.Length < word2.Length) Console.WriteLine($"La parola più corta è: {word1} e la parola più lunga è: {word2}");
                else Console.WriteLine("Le due parole hanno la stessa lunghezza");
            }

            Console.WriteLine();

            {
                // Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.
                Console.WriteLine(Program.Prettifier("Snack 3"));
                int[] numbers = new int[10];
                for (int i = 0; i < numbers.Length; i++)
                {
                    while (control)
                    {
                        try
                        {
                            Console.WriteLine($"Inserisci il {i + 1}° numero");
                            numbers[i] = Convert.ToInt32(Console.ReadLine());
                            control = false;
                        } catch (FormatException)
                        {
                            Console.WriteLine("ERRORE: Il valore inserito non è un numero");
                            control = true;
                        }
                    }
                    control = true;
                }
                Console.WriteLine($"La somma dei numeri inseriti è: {numbers.Sum()}");

            }

            Console.WriteLine();

            {
                // Snack 4: Calcola la somma e la media dei numeri da 2 a 10.
                Console.WriteLine(Program.Prettifier("Snack 4"));
                int sum = 0;
                float avg = 0;
                for (int i = 2; i <= 10; i++)
                {
                    sum += i;
                }
                avg = sum / 9;
                Console.WriteLine($"La somma dei numeri da 2 a 10 è: {sum}");
                Console.WriteLine($"La media dei numeri da 2 a 10 è: {avg}");
            }

            Console.WriteLine();

            {
                // Snack 5: Il software chiede all’utente di inserire un numero.Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
                Console.WriteLine(Program.Prettifier("Snack 5"));
                int num = 0;
                while (control)
                {
                    try
                    {
                        Console.WriteLine("Inserisci un numero");
                        num = Convert.ToInt32(Console.ReadLine());
                        control = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("ERRORE: Il valore inserito non è un numero");
                        control = true;
                    }
                }
                control = true;
                Console.WriteLine($"output: {(num % 2 == 0 ? num : num + 1)}");
            }

            Console.WriteLine();

            {
                // Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
                Console.WriteLine(Program.Prettifier("Snack 6"));
                string[] invited = { "francesco", "gabriele", "gianmarco", "valerio", "davide", "adnrea" };
                string name = "";
                while (control)
                {
                    try
                    {
                        Console.WriteLine("Inserisci il tuo nome");
                        name = Console.ReadLine();
                        control = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("ERRORE: Il valore inserito non è una stringa");
                        control = true;
                    }
                }
                control = true;
                if (invited.Contains(name.ToLower())) Console.WriteLine($"Puoi partecipare alla festa, {name}!");
                else Console.WriteLine($"Non ho trovato il tuo nome nella lista degli invitati, {name}.");
            }

            Console.WriteLine();

            {
                // Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
                Console.WriteLine(Program.Prettifier("Snack 7"));
                int[] numbers = new int[6];
                int input = 0;
                for (int i = 0; i < 6; i++)
                {
                    while (control)
                    {
                        try
                        {
                            Console.WriteLine($"Inserisci il {i + 1}° numero");
                            input = Convert.ToInt32(Console.ReadLine());
                            control = false;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("ERRORE: Il valore inserito non è un numero");
                            control = true;
                        }
                    }
                    control = true;
                    if (input % 2 != 0) numbers[i] = input;
                }
                int[] output = numbers.Where(number => number != 0).ToArray();
                if (output.Length != 0) Console.WriteLine($"I numeri dispari selezionati sono: {String.Join(", ", output)}");
                else Console.WriteLine("Non hai selezionato numeri dispari.");
            }

            Console.WriteLine();

            {
                // Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
                Console.WriteLine(Program.Prettifier("Snack 8"));
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 4, 45, 2, 3, 45, 25345 };
                int sum = 0;
                for (int i = 1; i < numbers.Length; i += 2)
                {
                    sum += numbers[i];
                }
                Console.WriteLine($"La somma dei numeri in posizione dispari è: {sum}");
            }

            Console.WriteLine();

            {
                // Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
                Console.WriteLine(Program.Prettifier("Snack 9"));
                int sum = 0;
                int input = 0;
                int[] numbers = { };
                while (sum < 50)
                {
                    while (control)
                    {
                        try
                        {
                            Console.WriteLine($"La somma attuale è: {sum}");
                            Console.WriteLine($"Inserisci un numero");
                            input = Convert.ToInt32(Console.ReadLine());
                            control = false;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("ERRORE: Il valore inserito non è un numero");
                            control = true;
                        }
                    }
                    control = true;
                    sum += input;
                    numbers = numbers.Concat(new int[] { input }).ToArray();
                }
                Console.WriteLine($"I numeri inseriti sono: {String.Join(", ", numbers)}");
                Console.WriteLine($"La loro somma è: {sum}");
            }

            Console.WriteLine();

            {
                // Snack 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.
                Console.WriteLine(Program.Prettifier("Snack 10"));
                int n = 0;
                while (control)
                {
                    try
                    {
                        Console.WriteLine("Inserisci un numero");
                        n = Convert.ToInt32(Console.ReadLine());
                        control = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("ERRORE: Il valore inserito non è un numero");
                        control = true;
                    }
                }
                control = true;
                int[][] randArrays = new int[n][];
                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    randArrays[i] = new int[10];
                    for (int j = 0; j < 10; j++)
                    {
                        randArrays[i][j] = r.Next(1, 100);
                    }
                    Console.WriteLine(String.Join(", ", randArrays[i]));
                }
            }



        }

        private static string Prettifier(string input)
        {
            string output = $"{String.Concat(Enumerable.Repeat("-", input.Length+2))} \n {input.ToUpper()} \n{String.Concat(Enumerable.Repeat("-", input.Length+2))}";
            return output;
        }
    }
}
