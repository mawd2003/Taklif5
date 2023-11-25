using System;

namespace MaxMin
{
    class Program
    {
        public static void Main()
        {
            Random Rand = new Random();
            int[] array = new int[50];
			
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Rand.Next(0, 1000);
            }
			maxmin(array);
		}
		
		static void maxmin(int [] array)
		{
            int max = array[0];
            for (int i = 1; i <= 49 ; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            int min = array[0];
            for (int i = 1; i <= 49; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
			
            int sum = max + min;
            int sub = max - min;

           
            Console.WriteLine(" Max is : {0}" , max);
            Console.WriteLine(" Min is : {0}" , min);
			      Console.WriteLine(" Sum is : {0}" , sum);
			      Console.WriteLine(" Sub is : {0}" , sub);
    }
}
}
