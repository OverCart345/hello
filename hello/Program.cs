namespace hello
{
    internal class Program
    {
        static void Main()
        {
            int[,] matrix = new int[10, 10] {
            {1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
            {1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
            {1, 1, 1, 1, 0, 0, 0, 1, 1, 0 },
            {0, 0, 1, 1, 1, 0, 0, 1, 1, 0 },
            {0, 0, 0, 1, 1, 1, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 1, 1, 0, 0 },
            {0, 0, 0, 0, 0, 0, 1, 1, 1, 1 },
            {0, 0, 0, 0, 0, 0, 0, 1, 1, 1 },
            {0, 0, 0, 0, 0, 0, 0, 1, 1, 1 },
            };

        Queue<int> queue = new Queue<int>();
        List<List<int>> components = new List<List<int>>
            {
                new List<int>()
            };
        queue.Enqueue(1);
            int k = 0;

            for (int i = 0; i< 10; i++)
            {
                for (int j = 0; j< 10; j++)
                {
                    if (matrix[i, j] == 1 && !queue.Contains(j + 1) && !components[k].Contains(j + 1))
                    {
                        queue.Enqueue(j + 1);
                    }
                }

                components[k].Add(queue.Dequeue());

                if (queue.Count == 0)
                {
                    components.Add(new List<int>());
                    k++;
                }
            }

            foreach (var item in components)
            {
                foreach (var vert in item)
                {
                    Console.Write(vert + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}