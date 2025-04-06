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
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            Random random = new Random();
            for(int i = 0; i < 100; i++)
            {
                data.Add(random.Next(-100, 100));
            }

            data = CountingSort(data);

            for(int i = 0; i < data.Count; i++)
            {
                Console.Write(data[i] + " ");
            }
        }
    }
}
