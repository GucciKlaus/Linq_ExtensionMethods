

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Link_ExtensionMethods
{
    public static class MyExtensionMethods
    {
        public static List<T> Take<T>(this List<T> list, int anzahl)
        {
            List<T> list2 = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                if (i <= anzahl)
                {
                    list2.Add(list[i]);
                }
            }
            return list2;
        }

        public static List<T> Skip<T>(this List<T> list, int anzahl)
        {
            List<T> list2 = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                if (i > anzahl)
                {
                    list2.Add(list[i]);
                }
            }
            return list2;
        }

        public static List<T> Distinct<T>(this List<T> list)
        {
            List<T> list2 = new List<T>();
            foreach (var item in list)
            {
                if (!list2.Contains(item))
                {
                    list2.Add(item);
                }
            }
            return list2;
        }

        public static List<T> MyReverse<T>(this List<T> list)
        {
            List<T> returnList = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                returnList.Insert(0, list[i]);
            }
            return returnList;
        }

        public static T MyFirst<T>(this List<T> list)
        {
            if (list != null)
            {
                return list[0];
            }
            else
            {
                throw new Exception("Kein Element");
            }
        }

        public static T MyElementAt<T>(this List<T> list, int index)
        {
            return list[index];
        }

        public static T MyFirstOrDefault<T>(this List<T> list)
        {
            if (list != null)
            {
                return MyFirst(list);
            }
            else
            {
                return default(T);
            }
        }

        public static List<T> MyTakeWhile<T>(this List<T> list, Predicate<T> p)
        {
            List<T> list2 = new List<T>();
            int count = 0;
            while (count < list.Count && p(list[count]))
            {
                list2.Add(list[count]);
                count++;
            }
            return list2;
        }

        public static List<T> MySkipWhile<T>(this List<T> list, Predicate<T> p)
        {
            List<T> list2 = new List<T>();
            int index = 0;
            while (index < list.Count && p(list[index]))
            {
                index++;
            }

            while (index < list.Count)
            {
                list2.Add(list[index]);
                index++;
            }
            
            
            return list2;
        }

        public static List<TRes> MySelect<T,TRes>(this List<T> list,Func<T,TRes> f)
        {
            List<TRes> list2 = new List<TRes>();
            foreach(T item in list)
            {
                list2.Add(f(item));
            }
            return list2;
        }

        public static List<T> MyOrderBy<T>(this List<T> list,Comparison<T> comparison)
        {
            List<T> returnList = new List<T>();
            foreach(T item in list)
            {
                int i = 0;
                while (i < list.Count && i < returnList.Count && comparison(item, returnList[i]) > 0)
                {
                    i++;
                }

                returnList.Insert(i, item);
            }
            return returnList;
        }
        public static List<T> MyOrderBydown<T>(this List<T> list, Comparison<T> comparison)
        {
            List<T> returnList = new List<T>();
            foreach (T item in list)
            {
                int i = 0;
                while (i < list.Count && i < returnList.Count && comparison(item, returnList[i]) < 0)
                {
                    i++;
                }

                returnList.Insert(i, item);
            }
            return returnList;
        }

        public static List<T> MyWhere<T>(this List<T> list, Predicate<T> p)
        {
            List<T> list2 = new List<T>();
            foreach(var item in list)
            {
                if(p(item))
                {
                    list2.Add(item);
                }
            }

            return list2;
        }



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
            foreach (var item in list)
            {
                if (item > max)
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

        //Des hätte ma spoan kinna
        //public static double Average(this List<double> list)
        //{
        //    double sum = Sum(list);
        //    double count = Count(list);
        //    decimal average = (decimal)(sum / count);
        //    average = decimal.Round(average, 2);
        //    return (double)average;
        //}

        //public static double Max(this List<double> list)
        //{
        //    double max = list[0];
        //    foreach (var item in list)
        //    {
        //        if (item > max)
        //        {
        //            max = item;
        //        }
        //    }
        //    decimal max2 = decimal.Round((decimal)max,2);
        //    return (double)max2;
        // }

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
