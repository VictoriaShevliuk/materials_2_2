using System;

namespace ConsoleApp2
{
    class Program
    {
		public static int inpMin(string txt, int min)
		{
			int outp = -1;
			string inp;

				System.Console.WriteLine("\n" + txt);
				inp = System.Console.ReadLine();

			
			return outp;
		}

		static void Main(string[] args)
        {
			Graph myGraph = new Graph(inpMin("Enter your vertices:", 1));
			int ans = 0;

			
		
				ans = inpMin("Enter:\n► 1 show vertex number,\n► 2 show  matrix,\n► 3 show edge,\n► 4 show all edges," +
					"\n► 5 to add  edge,\n► 6  remove edge,\n► 7 find the shortest path,\n► 8  exit.", 1);
				switch (ans)
				{
					case (1):
						myGraph.showVN();
						break;
					case (2):
						myGraph.showVN();
						break;
					case (3):
						myGraph.showEdge(inpMin("input the first vertex index", 0), inpMin("input the second vertex index", 0));
						break;
					case (4):
						myGraph.showAllEdg();
						break;
					case (5):
						myGraph.addEdge(inpMin("input the first vertex index", 0), inpMin("input the second vertex index", 0), inpMin("Enter the weight", 0));
						break;
					case (6):
						myGraph.deleteEdge(inpMin("input the first vertex index", 0), inpMin("input the second vertex index", 0));
						break;
					case (7):
						myGraph.printShortestPath(inpMin("input the first vertex index", 0), inpMin("input the second vertex index", 0));
						break;
					case (8):
						break;
				}
			
		}

	}
}

