using System;

public class FibonacciSeries
{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter number for fibonacci");
			int n = Convert.ToInt32(Console.ReadLine());
			int n1 = 0;
			int n2 = 1;
			if (n == n1)
			{
				Console.WriteLine(n1);
			}
			else if (n == n2)
			{
				Console.WriteLine(n1 + " " + n2);
			}
			else
			{
				for(int i=1; i<=n; i++)
				{
					Console.Write(n1+" ");
					Console.Write(n2+" ");
					int n3 = n1 + n2;
					n1 = n2;
					n2 = n3;

				}
			}
		}

	
}
