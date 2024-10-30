using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_BT5
{
    internal class Program
    {
        static void TestInput()
        {
            MyBinaryTree root = new MyBinaryTree();
            root.Input();
            int[] a = { 7, 36, 3, 1, 6, 4, 15, 40 };
            foreach (int giatri in a)
                root.Insert(giatri);
            Console.WriteLine("Duyet cay NLR: ");
            root.PreOrder();
            Console.WriteLine("\nDuyet cay LNR: ");
            root.InOrder();
            Console.WriteLine("\nDuyet cay LRN: ");
            root.PostOrder();
            Console.WriteLine("So node la tren cay la %d", root.CountLeaf(root.Root));
        }
        static void Main(string[] args)
        {
            TestInput();
        }
    }
}
