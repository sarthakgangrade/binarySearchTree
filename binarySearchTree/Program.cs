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
            tree.Insert(70);
            tree.Insert(50);
            tree.Insert(95);
            tree.Insert(67);
            tree.Insert(68);
            tree.Insert(11);
            tree.Insert(3);
            tree.Insert(16);
            Console.WriteLine(" After insert node the Binary Tree is:");
            tree.inorder();
        }
    }
}
