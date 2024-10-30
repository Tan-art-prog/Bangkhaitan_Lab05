using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangkhaitan_Lab05
{
    internal class IntTNode
    {
        private int data;
        private IntTNode left;
        private IntTNode right;
        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public IntTNode Left
        {
            get { return left; }
            set { left = value; }
        }
        public IntTNode Right
        {
            get { return right; }
            set { right = value; }
        }
        public IntTNode(int x = 0)
        {
            data = x;
            left = null;
            right = null;
        }
        public bool InsertNode(int x)
        {
            if (data == x) //Trùng giá trị
                return false;
            if (data > x)
            // Giá trị cần thêm nhỏ hơn
            //-> chèn về trái
            {
                if (left == null)
                    left = new IntTNode(x);
                else
                    return left.InsertNode(x);
            }
            else
            //Giá trị cần thêm lớn hơn
            //-> chèn về phải
            {
                if (right == null)
                    right = new IntTNode(x);
                else
                    return right.InsertNode(x);
            }
            return true;
        }
        public void NLR()
        {
            Console.Write(Data + "; ");
            if (left != null)
                left.NLR();
            if (right != null)
                right.NLR();
        }
        public void LNR()
        {
            if (left != null)
                left.LNR();
            Console.Write(Data + "; ");
            if (right != null)
                right.LNR();
        }
        public void LRN()
        {
            if (left != null)
                left.LRN();
            Console.Write(Data + "; ");
            if (right != null)
                right.LRN();
        }
    }
}
