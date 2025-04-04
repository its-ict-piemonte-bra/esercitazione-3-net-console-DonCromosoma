using System.Numerics;

namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            //LessonInformation();

            //int[] vettore = LoadArray(10);

            Console.WriteLine("Ora gli esercizi");
            // Console.WriteLine("Esercizio 1:");
            // Esercizio1();

            // Console.WriteLine("\nEsercizio 2:");
            // Esercizio2();

            // Console.WriteLine("\nEsercizio 3:");
            // Esercizio3();

            // Console.WriteLine("\nEsercizio 4:");
            // Esercizio4();

            /*
            int[,] matrix = LoadMatrix();
            PrintMatrix(matrix, "matrice");
            */

            //Console.WriteLine("\nEsercizio 5:");
            //Esercizio5();

            Console.WriteLine("\nEsercizio 6:");
            Esercizio6();
        }

        private static void Esercizio1()
        {
            Console.Write("Inserire N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int[] arraySource= LoadArray(n);
            int[] arrayDestination = new int[n];

            for (int i = 0; i < n ; i++) 
            {
                arrayDestination[i]= arraySource[i];
            }

            PrintArray(arraySource, "arraySource");
            PrintArray(arrayDestination, "arrayDestination");

        }

        private static void Esercizio2() 
        {
            Console.Write("Inserire N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arraySource = LoadArray(n);
            int[] arrayDestination = new int[n];

            for (int i = 0; i < n; i++)
            {
                arrayDestination[n-i-1] = arraySource[i];
            }

            PrintArray(arraySource, "arraySource");
            PrintArray(arrayDestination, "arrayDestination");

        }

        private static void Esercizio3() 
        {
            Console.Write("Inserire N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arraySource = LoadArray(n);
            Console.WriteLine("Prima della inversione: ");
            PrintArray(arraySource, "arraySource");

            for (int i = 0; i < n / 2; i++) 
            {
                Console.WriteLine("");
            }
        }

        private static void Esercizio4()
        {
            Console.Write("Inserire N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arraySource = LoadArray(n);

            if (n == 0)
            {
                Console.WriteLine("Non posso trovare massimo e minimo in un array vuoto");
            }
            else 
            {
                int max = arraySource[0];
                int min = arraySource[0];

                for (int i = 1; i < n; i++) 
                {
                    if(arraySource[i] > max)
                    {
                        max= arraySource[i];
                    }
                    if (arraySource[i] < min) 
                    {
                        min = arraySource[i];   
                    }
                }

                Console.WriteLine($"Il valore massimo è {max}");
                Console.WriteLine($"Il valore minimo è {min}");
            }

        }

        private static void Esercizio5() 
        {

            int[,] matrix1 = LoadMatrix();
            int[,] matrix2 = LoadMatrix();
            int[,] matrix3 = {};
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            PrintMatrix(matrix3, "MatriceDellaSomma");
            
        }

        private static void Esercizio6() 
        {
            int[,] matrix = LoadMatrix();
            int count = 0;
            Console.WriteLine("Inserisci un numero che vuoi cercare: ");
            int x= Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix.GetLength(1); j++) 
                {
                    if (x == matrix[i, j]) { count++; }
                }
            }
            Console.WriteLine($"{x} è stato trovato per: {count} volta\\e ");

        }


        private static int[,] LoadMatrix()
        {
            Console.Write("Inserire Righe: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserire Colonne: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int[,] result = new int[r,c];

                for (int i = 0; i < r ; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        Console.Write($"matrix[{i},{j}] = ");
                        result[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                return result;
            
        }
        private static void PrintMatrix(int[,] matrix, string nomeMatrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1); 


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{nomeMatrix}[{i},{j}] -> {matrix[i, j]} - ");
                }
                Console.WriteLine();
            }
        }

        private static int[] LoadArray(int n)
        {

            if (n<0) 
            {
                Console.WriteLine("N deve essere un numero positivo");
                return new int[0];
            }
            else
            {
                Console.WriteLine($"Carichiamo un vettore di {n} elementi...");
                int[] result = new int[n];

                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write($"array[{i}] = ");
                    result[i] = Convert.ToInt32(Console.ReadLine());
                }

                return result;
            }

            
        }        
        private static void PrintArray(int[] array, string nomeArray)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{nomeArray}[{i}] -> {array[i]}");
            }
        }


        #region Lesson Informatiom
        /// <summary>
        /// Informazioni sui tipi di dati .NET
        /// </summary>
        private static void LessonInformation()
        {
            Console.WriteLine("Esercitazione 3 - .NET Console");

            Console.WriteLine("I tipi primitivi:");
            Console.WriteLine(@"I tipi di dato primitivo sono quei tipi di dato 
                                elementare che non possono essere scomposti in tipi più semplici.
                                Rientrano in questa categoria i seguenti tipi di dato:
                                -bool
                                -byte, short, int, long
                                -float, double, decimal
                                -char
                                -string");
            Console.WriteLine("\nI tipi derivati:");
            Console.WriteLine(@"I tipi di dato derivati sono quei tipi di dato
                                non elementare che si erano componendo i tipi primitivi in diverse
                                maniere.
                                Rientrano in questa categoria i seguenti tipi di dato:
                                -gli array (su qualsiasi dimensione) - tipi primitivi allocati in maniera omogenea
                                -le struct - tipi primitivi allocati in maniera non omogenea
                                -le classi - tipi primitivi allocati in maniera omogenea, che seguono
                                             le regole della programmazione ad oggetti
                                             (Object Oriented Programming - OOP)");

            Console.WriteLine("Gli array:");
            Console.WriteLine(@"Definiamo array una variabile che consiste nell'allocazione
                                contigua di celle di memoria che contengono valori appartenenti allo stesso
                                tipo primitivo.
                                Tipicamnte noi conosciamo gli array  mono-dimensionali, e chiamiamo 'matrici'
                                gli array multi-dimensionali");

            //inizializzazione diretta
            //con questa inizializzazione impoistiamo 
            //tutti i valore delle celle dell'array e
            //solo quelle (non ne aggiungiamo altre vuote)
            //
            //int[] array;
            int[] array = { 1, 2, 3, 4 };

            //inizializzazione array vuoto di dimension 10
            //con questa inizializzazione impostiamo le 10 celle a
            //zero. Non ne aggiungiamo altre vuote
            int[] array2 = new int[10];

            //la dimensione non deve essere per forza definita come
            //costante: le variabili vanno anche bene.
            int n = 10;
            int[] array3 = new int[n];


            //Il metodo Array.Resize ridimensione un array mono-dimensionale
            //dandogli una nuova dimensione.
            //
            //Se la nuova dimensione è maggiore della precedente, aggunge nuove
            //celle impostando lo zero-value.
            //
            //Se la nuova dimensione è minore della precedente, gli ultimi elementi
            //verranno eliminati per fare spazio.
            //
            //la parola chiave "ref" serve a passare per referenza la variabili.
            Array.Resize(ref array3, n * 2);

            Console.WriteLine(@"Per accedere a una cella di un array, usiamo la notazione
                                'a indice' (array[indice]). Questo si può fare sia per la lettura che per
                                l'impostazione / assegnamento");

            //imposto
            array[0] = 10;

            //leggo
            Console.WriteLine(array[0]);

            //l'indice può essere una variabile
            int x = 1;
            Console.WriteLine($"array[{x}] -> {array[x]}");

            //è possibile scorrere un array di qualsiasi tipo con uno o più cicli
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] -> {array[i]}");
            }

            //inizializzazione diretta
            int[,] matrix2DZero = new int[10, 10];

            //assegnamento (notare come gli indici sono 2)
            matrix2DZero[0, 1] = 1;

            //lettura
            x = 1;
            int y = 1;
            Console.WriteLine($"matrix2DZero[{x}, {y}] -> {matrix2DZero[x, y]}");

            //inizializzazione diretta di una matrice a 3 dimensioni
            int[,,] matrix3D =
            {
                {
                    {1,2},
                    {3,4},
                },
                {
                    {5,6},
                    {7,8},
                },
            };

            //lettura
            int z = 0;
            Console.WriteLine($"matrix3D[{x},{y},{z}] -> {matrix3D[x,y,z]}");
            Console.WriteLine(@"Per ottenere gli elementi in una determinata dimensione,
                                usiamo il metodo .GetLength(dimensione)");

            int rows = matrix2DZero.GetLength(0);
            int columns= matrix2DZero.GetLength(1);
            Console.WriteLine($"matrix2D ha {rows} righe e {columns} columns");

            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++) 
                {
                    Console.WriteLine("");
                }
            }  


        }
        #endregion 
    }
}
