using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangkhaitan_Lab05
{
    internal class MyBinaryTree
    {
        private IntTNode root;

        public IntTNode Root
        {
            get { return root; }
            set { root = value; }
        }
        public MyBinaryTree()
        {
            Root = null;
        }
        private int CountNodes(IntTNode node)
        {
            if (node == null)
                return 0;
            return 1 + CountNodes(node.Left) + CountNodes(node.Right);
        }
        private int CalculateHeight(IntTNode node)
        {
            if (node == null)
                return 0;
            int leftHeight = CalculateHeight(node.Left);
            int rightHeight = CalculateHeight(node.Right);
            return 1 + Math.Max(leftHeight, rightHeight);
        }
        public int CountLeaf(IntTNode node)
        {
            if (node == null)
                return 0;
            if (node.Left == null && node.Right == null)
                return 1;
            return CountLeaf(node.Left) + CountLeaf(node.Right);
        }
        public bool Insert(int x)
        {
            if (Root == null)
            {
                Root = new IntTNode(x);
                return true;
            }
            return Root.InsertNode(x);
        }
        public void Input()
        {
            do
            {
                int x;
                Console.Write("Nhap vao gia tri: ");
                int.TryParse(Console.ReadLine(), out x);
                if (Insert(x) == true)
                    Console.WriteLine("Da them");
                else
                {
                    Console.WriteLine("Ket thuc");
                    return;
                }
            } while (true);
        }
        public void PreOrder()
        {
            if (Root == null)
                return;
            Root.NLR();
            Console.WriteLine();
        }
        public void InOrder()
        {
            if (Root == null)
                return;
            Root.LNR();
            Console.WriteLine();
        }
        public void PostOrder()
        {
            if (Root == null)
                return;
            Root.LRN();
            Console.WriteLine();
        }
        public bool FindX(IntTNode node, int x)
        {
            if (node == null)
                return false;
            if (node.Data == x)
                return true;
            if (x < node.Data)
                return FindX(node.Left, x);
            else
                return FindX(node.Right, x);
        }
    }
}