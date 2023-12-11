

namespace Link_ExtensionMethods
{
    public static class MyExtensionMethods
    {
        public static int Count<T>(this List<T> list)
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


        public static double Count(this List<double> list)
        {
            int counter = 0;
            foreach (var item in list)
            {
                counter++;
            }
            return counter;
        }

        public static double Sum(this List<double> list)
        {
            double sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }
            decimal sumround = decimal.Round((decimal)sum, 2);
            return (double)sumround;
        }

        public static double Average(this List<double> list)
        {
            double sum = Sum(list);
            double count = Count(list);
            decimal average = (decimal)(sum / count);
            average = decimal.Round(average, 2);
            return (double)average;
        }

        public static double Max(this List<double> list)
        {
            double max = list[0];
            foreach (var item in list)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            decimal max2 = decimal.Round((decimal)max,2);
            return (double)max2;
        }

        public static List<T> Where<T>(this List<T> inputList, Predicate<T> predicate)
        {
            var returnList = new List<T>();

            foreach (var item in inputList)
            {
                if (predicate(item))
                {
                    returnList.Add(item);
                }
            }

            return returnList;
        }


    }
}
