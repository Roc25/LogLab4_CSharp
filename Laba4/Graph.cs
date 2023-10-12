using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Graph
    {
        public GraphNode Root;

        public Graph() { 
        }

        public Graph(GraphNode root) {
            Root = root;
        }

        public int Search(GraphNode node, string data) {
            if (node.Data == data){
                return node.ID;
            }


            if (node.Left != null) {
                int result = Search(node.Left, data);
                if (result != -1){
                    return result;
                }
            }

            if (node.Right != null){
                int result = Search(node.Right, data);
                if (result != -1){
                    return result;
                }
            }

            return -1;
        }

        public GraphNode Insert(GraphNode node, string data, int id){
            if (Search(Root, data) == -1) return null;

            if (node.Left == null){
                node.Left = new GraphNode(data, id);
                return node.Left;
            }

            if (node.Right == null){
                node.Right = new GraphNode(data, id);
                return node.Right;
            }

            return null;
        }

        public int Count(GraphNode node, string data){
            int res = 0;
            if (node.Data == data){
                res += 1;
            }


            if (node.Left != null){
                res += Count(node.Left, data);
            }

            if (node.Right != null){
                res += Count(node.Right, data);
            }

            return res;
        }

        public string displayNode()
        {
            StringBuilder output = new StringBuilder();
            displayNode(output, Root, 0);
            return output.ToString();
        }

        private void displayNode(StringBuilder output, GraphNode node, int depth){

            if (node.Right != null){
                displayNode(output, node.Right, depth + 1);
            }

            output.Append('\t', depth);
            output.AppendLine(node.Data.ToString());


            if (node.Left != null)
            {
                displayNode(output, node.Left, depth + 1);
            }
        }

        }
    }
