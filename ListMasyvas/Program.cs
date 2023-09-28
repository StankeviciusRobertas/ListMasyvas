using Microsoft.VisualBasic;
using System.Text;

namespace ListMasyvas
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<int> sarasas = new List<int>();
            //int[] ints = { 26, 5, 26, 56, 256 };

            //sarasas.Add(1);
            //sarasas.Add(6);
            //sarasas.Add(4);
            //sarasas.Add(3);

            //sarasas.AddRange(ints);

            //int firstElement = sarasas[0];

            ////sarasas.RemoveAt(0); // Pasalina pagal pozicija

            //sarasas.Remove(3); // Pasalina pagal reiksme

            //int kiekis = sarasas.Count;

            //List<int> filtruotas = sarasas.FindAll(x => x % 2 == 0);

            //filtruotas.Sort();

            //for (int i = 0; i < filtruotas.Count; i++)
            //{
            //    Console.WriteLine(filtruotas[i]);
            //}            

            //////////////////////////////////////////////////////////////

            //List<string> strings = new List<string> { "robertas", "petras", "antanas" };
            //PrintLenghtOfList(strings);

            //////////////////////////////////////////////////////////////

            //List<int> numbers = new List<int>(GetNumbers());
            //int Sum = GetSumOfList(numbers);
            //Console.WriteLine($"Saraso elementu vidurki: {Sum}");

            //////////////////////////////////////////////////////////////

            //List<int> list = new List<int>(GetNumbers());
            //int sumBigger = GetBiggerWhen(list);

            //////////////////////////////////////////////////////////////

            List<string> words = new List<string> { "robertas", "petras", "antanas" };
            WordsBackSumEqual(words);

        }

        public static List<string> WordsBackSumEqual(List<string> words)
        {
            List<string> stringList = new List<string>();
            for (int i = 0; i < words.Count; i++)
            {
                char result = stringList[0][0];
                byte asciiKodas = System.Convert.ToByte(result);
                int sum = 0;

                foreach (char c in asciiKodas)
                {
                    int asciiValue = (int)c;
                    sum += asciiValue;
                }

                return sum;
            }
        }
        public static int GetBiggerWhen(List<int> list)
        {            
            foreach (int i in list)
            {
                if (i > 10)
                {
                    Console.WriteLine(i);
                }
            }
            return -1;
        }
        public static int GetSumOfList(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum/numbers.Count;
        }
        public static List<int> GetNumbers()
        {
            List<int> ints = new List<int>();
            int i = 0;
            int numbers = 0;
            while (i <= 5)
            {                
                Console.WriteLine("Iveskite skaiciu");
                numbers = Convert.ToInt32(Console.ReadLine());
                ints.Add(numbers);
                i++;
            }
            return ints;
        }        
        public static void PrintLenghtOfList(List<string> strings)
        {
            foreach (string s in strings)
            {
                Console.WriteLine(s.Length);
            }
        }
    }
}