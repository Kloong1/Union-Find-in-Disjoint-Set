using System;
using System.Text;

namespace Set{

	class MainApp {
		public static void Main(){
			DisjointSet ds = new DisjointSet();
			int input = 0;
			do{
				switch (input = PrintMenu())
				{
					case 1:
						CallInit(ds);
						break;
					case 2:
						CallFind(ds);
						break;
					case 3:
						CallUnion(ds);
						break;
					case 4:
						Console.WriteLine("Exit.");
						break;
					default:
						Console.WriteLine("Error: Wrong Input!");
						break;
				}
				Console.WriteLine();
			}while(input != 4);
		}

		static int PrintMenu(){
			Console.WriteLine("\n1. Init");
			Console.WriteLine("2. Find");
			Console.WriteLine("3. Union");
			Console.WriteLine("4. Exit");
			Console.Write("Input: ");

			string sInput = Console.ReadLine();
			return Convert.ToInt32(sInput); 
		}

		static void CallInit(DisjointSet ds){
			Console.WriteLine("\nInit");
			Console.Write("Input Set Size: ");
			string input = Console.ReadLine();
			int size = Convert.ToInt32(input);

			ds.Init(size);
		}

		static void CallFind(DisjointSet ds){
			Console.WriteLine("\nFind");
			Console.Write("Input: ");
			string input = Console.ReadLine();
			int element = Convert.ToInt32(input);

			Console.WriteLine("Root: {0}", ds.Find(element));
		}

		static void CallUnion(DisjointSet ds){
			Console.WriteLine("\nUnion");
			Console.Write("Input e1: ");
			string input = Console.ReadLine();
			int e1 = Convert.ToInt32(input);

			Console.Write("Input e2: ");
			input = Console.ReadLine();
			int e2 = Convert.ToInt32(input);

			int r1 = ds.Find(e1);
			int r2 = ds.Find(e2);

			if(r1 == r2){
				Console.WriteLine($"Error: {e1} and {e2} are in the same set {r1}");
				return;
			}
			ds.Union(r1, r2);
		}
	}
}
