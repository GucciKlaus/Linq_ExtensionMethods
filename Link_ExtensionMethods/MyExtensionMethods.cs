

namespace Link_ExtensionMethods
{
    public static class MyExtensionMethods
    {
        public static int Count(this List<int> list)
        {
            int counter = 0;
            foreach (var item in list)
            {
                counter++;
            }
            return counter;
        }

        public static int Sum(this List<int> list)
        {
            int sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }
            return sum;
        }

        public static int Average(this List<int> list)
        {
            int sum = Sum(list);
            int count = Count(list);
            return sum / count;
        }

        public static int Max(this List<int> list)
        {
            int max = list[0];
            foreach(var item in list)
            {
                if(item > max)
                {
                    max = item;
                }
            }
            return max;
        }
        public static int Min(this List<int> list)
        {
            int min = list[0];
            foreach (var item in list)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
    }
}
