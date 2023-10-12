using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Program
    {
        static void Main(string[] args){

            GraphNode node1 = new GraphNode("1", 4);
            GraphNode node2 = new GraphNode("2", 5);

            GraphNode node3 = new GraphNode("2", 6);
            GraphNode node4 = new GraphNode("3", 7);

            GraphNode node5 = new GraphNode("3", 2, node1, node2);
            GraphNode node6 = new GraphNode("6", 3, node3, node4);

            GraphNode node7 = new GraphNode("7", 1, node5, node6);

            Graph g = new Graph(node7);

            Console.WriteLine("O(n)");

            Console.WriteLine(g.displayNode());

            while (true){
                Console.WriteLine("Введите искомое значение:");
                string inp = Console.ReadLine();

                Console.WriteLine(g.Count(g.Root, inp));
            }

        }
    }
}
