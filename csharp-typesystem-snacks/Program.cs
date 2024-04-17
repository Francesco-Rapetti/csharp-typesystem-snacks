using System;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
            // Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.
            Console.WriteLine(Program.Prettifier("Snack 1"));
            Console.WriteLine("Inserisci il primo intero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo intero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Il numero maggiore tra {num1} e {num2} è: {Math.Max(num1, num2)}");
            }

            Console.WriteLine();

            {
            // Snack 2: L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.
            Console.WriteLine(Program.Prettifier("Snack 2"));
            Console.WriteLine("Inserisci la prima parola");
            string word1 = Console.ReadLine();
            Console.WriteLine("Inserisci la seconda parola");
            string word2 = Console.ReadLine();
            if (word1.Length > word2.Length) Console.WriteLine($"La parola più corta è: {word2} e la parola più lunga è: {word1}");
            else if (word1.Length < word2.Length) Console.WriteLine($"La parola più corta è: {word1} e la parola più lunga è: {word2}");
            else Console.WriteLine("Le due parole hanno la stessa lunghezza");
            }

            Console.WriteLine();

            {
            // Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.
            Console.WriteLine(Program.Prettifier("Snack 3"));
            }

            Console.WriteLine();

            {
            // Snack 4: Calcola la somma e la media dei numeri da 2 a 10.
            Console.WriteLine(Program.Prettifier("Snack 4"));
            }

            Console.WriteLine();

            {
            // Snack 5: Il software chiede all’utente di inserire un numero.Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
            Console.WriteLine(Program.Prettifier("Snack 5"));
            }

            Console.WriteLine();

            {
            // Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
            Console.WriteLine(Program.Prettifier("Snack 6"));
            }

            Console.WriteLine();

            {
            // Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
            Console.WriteLine(Program.Prettifier("Snack 7"));
            }

            Console.WriteLine();

            {
            // Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
            Console.WriteLine(Program.Prettifier("Snack 8"));
            }

            Console.WriteLine();

            {
            // Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
            Console.WriteLine(Program.Prettifier("Snack 9"));
            }

            Console.WriteLine();

            {
            // Snack 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.
            Console.WriteLine(Program.Prettifier("Snack 10"));
            }



        }

        private static string Prettifier(string input)
        {
            string output = $"{String.Concat(Enumerable.Repeat("-", input.Length+2))} \n {input.ToUpper()} \n{String.Concat(Enumerable.Repeat("-", input.Length+2))}";
            return output;
        }
    }
}
