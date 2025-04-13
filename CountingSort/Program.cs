using System.Linq;
using System.Numerics;

namespace CountingSort
{
    internal class Program
    {

        public static List<int> CountingSort(List<int> data) 
        {
            
            int maxVal = data.Max<int>();
            int minVal = data.Min<int>();
            int[] buckets = new int[maxVal + 1 - minVal];

            for(int i = 0; i < data.Count; i++)
            {
                buckets[data[i] - minVal] += 1;
            }

            List<int> list = new List<int>();
            for(int i = 0; i < buckets.Length; i++)
            {
                for(int j = 0; j < buckets[i]; j++)
                {
                    list.Add((int)i + minVal);
                }
            }
            


            return list;

        } 

        public static List<KeyValuePair<int, T>>[] PigeonSort<T>(List<KeyValuePair<int,T>> data) where T : IComparable<T>
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            for(int i = 0; i < data.Count; i++)
            {
                if (data[i].Key > max)
                {
                    max = data[i].Key;
                }
                if (data[i].Key < min)
                {
                    min = data[i].Key;
                }
            }

            //int[] buckets = new int[max + 1 - min];
            List<KeyValuePair<int, T>>[] buckets2 = new List<KeyValuePair<int, T>>[max + 1 - min];
            for (int i = 0; i < buckets2.Length; i++)
            {
                buckets2[i] = new List<KeyValuePair<int, T>>();
            }
            for (int i = 0; i < data.Count; i++)
            {
                buckets2[data[i].Key - min].Add(data[i]);
               
            }

            



            return buckets2;
        }
        static void Main(string[] args)
        {
            //List<int> data = new List<int>();
            //Random random = new Random();
            //for(int i = 0; i < 100; i++)
            //{
            //    data.Add(random.Next(-100, 100));
            //}

            //data = CountingSort(data);

            //for(int i = 0; i < data.Count; i++)
            //{
            //    Console.Write(data[i] + " ");
            //}


            List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();

            list.Add(new KeyValuePair<int, string>(4, "apple"));
            list.Add(new KeyValuePair<int, string>(1, "banana"));
            list.Add(new KeyValuePair<int, string>(3, "cat"));
            list.Add(new KeyValuePair<int, string>(6, "dog"));
            list.Add(new KeyValuePair<int, string>(5, "elephant"));
            list.Add(new KeyValuePair<int, string>(2, "fog"));
            list.Add(new KeyValuePair<int, string>(0, "gorilla"));


            List<KeyValuePair<int, string>>[] sortedBuckets = PigeonSort(list);

            for(int i = 0; i < sortedBuckets.Length; i++)
            {
               for(int j = 0; j < sortedBuckets[i].Count; j++)
                {
                    Console.WriteLine(sortedBuckets[i][j]);
                }
            }

        }
    }
}
