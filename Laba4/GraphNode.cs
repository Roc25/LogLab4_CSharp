using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class GraphNode
    {
        public string Data;
        public int ID;
        public GraphNode Left;
        public GraphNode Right;

        public GraphNode(string data, int id) {
            Data = data;
            ID = id;
        }
        public GraphNode(string data, int id, GraphNode left){
            Data = data;
            ID = id;
            Left = left;
        }
        public GraphNode(string data, int id, GraphNode left, GraphNode right){
            Data = data;
            ID = id;
            Left = left;
            Right = right;
        }


    }
}
