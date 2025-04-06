namespace CountingSort
{
    internal class Program
    {

        public static List<uint> CountingSort(List<uint> data) 
        {
            uint maxVal = data.Max<uint>();
            uint[] buckets = new uint[maxVal + 1];

            for(int i = 0; i < data.Count; i++)
            {
                buckets[data[i]] += 1;
            }

            List<uint> list = new List<uint>();
            for(int i = 0; i < buckets.Length; i++)
            {
                for(int j = 0; j < buckets[i]; j++)
                {
                    list.Add((uint)i);
                }
            }



            return list;

        } 
        static void Main(string[] args)
        {
            List<uint> data = new List<uint>();
            Random random = new Random();
            for(int i = 0; i < 100; i++)
            {
                data.Add((uint)random.Next(0, 100));
            }

            data = CountingSort(data);

            for(int i = 0; i < data.Count; i++)
            {
                Console.Write(data[i] + " ");
            }
        }
    }
}
