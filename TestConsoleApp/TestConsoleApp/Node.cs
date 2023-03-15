using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestDomeSolutions
{
    public class Node
    {
        public Node LeftChild { get; private set; }
        public Node RightChild { get; private set; }

        public Node(Node leftChild, Node rightChild)
        {
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        public int Height()
        {
           
                int leftDepth = this.LeftChild != null ? this.LeftChild.Height() : -1;
                int rightDepth = this.RightChild != null ? this.RightChild.Height() : -1;
                return 1 + Math.Max(leftDepth, rightDepth);
            
        }

        public static void Main(string[] args)
        {
            
        }
    }
}
