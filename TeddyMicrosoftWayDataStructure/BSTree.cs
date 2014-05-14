using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TeddyMicrosoftWayDataStructure
{
    //二叉查找树
    public class BSTNode
    {
        public int value;
        public BSTNode left;
        public BSTNode right;

        public BSTNode(int value, BSTNode left, BSTNode right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
        public BSTNode(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }

    public delegate void Visit(BSTNode node);

    public class BSTree
    {
        protected BSTNode root;
        public Visit visit;
        public BSTree()
        {
            this.root = null;
        }
        private BSTNode Search(BSTNode node, int el)
        {
            while (node != null)
            {
                if (el == node.value)
                {
                    return node;
                }
                else if (el < node.value)
                {
                    node = node.left;
                }
                else
                {
                    node = node.right;
                }
            }
            return null;
        }
        // Search Function
        public BSTNode Search(int el)
        {
            return Search(root, el);
        }
        // TO BE CONTINUED...
        public void BreadFirst()
        {
            
        }
        //先序
        protected void PreOrder(BSTNode p)
        {
            if (p != null)
            {
                visit(p);
                PreOrder(p.left);
                PreOrder(p.right);
            }
        }
        public void PreOrder()
        {
            PreOrder(root);
        }
        //中序
        protected void InOrder(BSTNode p)
        {
            if (p != null)
            {
                InOrder(p.left);
                visit(p);
                InOrder(p.right);
            }
        }
        public void InOrder()
        {
            InOrder(root);
        }
        //后序
        protected void PostOrder(BSTNode p)
        {
            if (p != null)
            {
                PostOrder(p.left);
                PostOrder(p.right);
                visit(p);
            }
        }
        public void PostOrder()
        {
            PostOrder(root);
        }
        //插入节点
        public void Insert(int el)
        {
            BSTNode p = root, prev = null;
            while (p != null)
            {
                prev = p;
                if (p.value < el)
                {
                    p = p.right;
                }
                else
                {
                    p = p.left;
                }
            }
            if (root == null)
            {
                root = new BSTNode(el);
            }
            else if (prev.value < el)
            {
                prev.right = new BSTNode(el);
            }
            else
            {
                prev.left = new BSTNode(el);
            }
        }

        public void Delete(int el)
        {
            BSTNode node, p = root, prev = null;
            //查找节点位置
            while (p != null && p.value != el)
            {
                prev = p;
                if (p.value < el)
                    p = p.right;
                else
                    p = p.left;
            }
            node = p;
            if (p != null && p.value == el)
            {
                if (node.right == null)
                    node = node.left;
                else if (node.left == null)
                    node = node.right;
                else
                {
                    BSTNode temp = node.left;
                    BSTNode previous = node;
                    while (temp.right != null)  //查找左字节数的最右子节点
                    {
                        previous = temp;
                        temp = temp.right;
                    }
                    node.value = temp.value;
                    if (previous == node)
                        previous.left = temp.left;
                    else
                        previous.right = temp.left;
                }
                if (p == root)
                    root = node;
                else if (prev.left == p)
                    prev.left = node;
                else
                    prev.right = node;
            }
            else if (root != null)
            {
                Console.WriteLine("There is so such node：{0}", el);
            }
            else
            {
                Console.WriteLine("Tree is null!");
            }
        }
    
    }
}
