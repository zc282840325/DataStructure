using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class BST<E> : Comparer<E>
    {
        private class Node {
            public E e;
            public Node left, right;

            public Node(E e)
            {
                this.e = e;
                left = null;
                right = null;
            }
        }

        private Node root;
        private int sizes;

        public BST() {
            root = null;
            sizes = 0;
        }

        public int size()
        {
            return sizes;
        }

        public bool isEmpty()
        {
            return sizes == 0;
        }

        //向二分搜索树中添加新的元素e
        public void add(E e)
        {
            //if (root==null)
            //{
            //    root = new Node(e);
            //    sizes++;
            //}
            //else
            //{
            //    add(root,e);
            //}
            root = add(root,e);
                
        }
        //向以node为根的二分搜索树中插入元素E，递归算法
        private Node add(Node node,E e)
        {
            if (node==null)
            {
                sizes++;
                return new Node(e);
            }

            if (Compare(e,node.e)<0)
            {
                node.left = add(node.left,e);
            }
            else if (Compare(e,node.e)>0)
            {
                node.right = add(node.right, e);
            }

            return node;
            //if (e.ToString()==node.e.ToString())
            //{
            //    return;
            //}
            //else if (Compare(e,node.e)<0&&node.left==null)
            //{
            //    node.left = new Node(e);
            //    sizes++;
            //    return;
            //}
            //else if (Compare(e,node.e)>0&&node.right==null)
            //{
            //    node.right = new Node(e);
            //    sizes++;
            //    return;
            //}
            //if (Compare(e,node.e)<0)
            //{
            //    add(node.left,e);
            //}
            //else
            //{
            //    add
        //    (node.right, e);
            //}
        }

        public override int Compare(E x, E y)
        {
            throw new NotImplementedException();
        }
    }
}
