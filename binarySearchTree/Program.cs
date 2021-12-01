using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BST tree = new BST();
            tree.Insert(65);
            tree.Insert(40);
            tree.Insert(60);
            Console.WriteLine(" After insert node the Binary Tree is:");
            tree.inorder();
        }
    }
}
