using System;

namespace SortByIndexOfLibrary
{
    public static class SortIndexLibrary
    {
        public static void Sort(int[] numbers)
        {
            if (numbers != null)
            {
                int temp = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    for (int i = 0; i < numbers.Length - 1; i++)
                    {
                        if (numbers[i] > numbers[i + 1])
                        {
                            temp = numbers[i]; // Interchanging of array's indexes
                            numbers[i] = numbers[i + 1];
                            numbers[i + 1] = temp;
                        }
                    }
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
           
        }

        public static int IndexOf(Product[] products, Predicate<Product> predicate)
        {
            if (products != null && predicate!=null)
            {
                for (int i = 0; i < products.Length; i++)
                {
                    var product = products[i];
                    if (predicate(product))
                    {
                        return i;
                    }
                }

                return -1;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}
