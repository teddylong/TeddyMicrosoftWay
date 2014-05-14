using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TeddyMicrosoftWayDataStructure
{
    class BSTreeDemo
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            int[] data = new int[] { 4, 8, 10, 34, 17, 1, 45, 3 };
            for (int i = 0; i < data.Length; i++)
            {
                tree.AddData(data[i]);
            }
            Console.Write("前序递归遍历的结果是：");
            tree.PreOrder(tree.RootNode);
            Console.Write("\n");

            Console.Write("中序递归遍历的结果是：");
            tree.MidOrder(tree.RootNode);
            Console.Write("\n");

            Console.Write("后序递归遍历的结果是：");
            tree.AfterOrder(tree.RootNode);
            Console.Write("\n");

            Console.Write("宽度遍历的结果是：");
            tree.DepthFirst();
            Console.Write("\n");

            Console.WriteLine("----------------------------我是华丽的分割线---------------------------");
            Console.Write("非递归的前序遍历结果为：");
            tree.nonrecursivePreOrder(tree.RootNode);
            Console.Write("\n");

            Console.Write("非递归的中序遍历结果为：");
            tree.nonrecursiveMidOrder(tree.RootNode);
            Console.Write("\n");

            Console.Write("非递归的后序遍历结果为：");
            tree.nonrecursiveAfterOrder(tree.RootNode);
            Console.Write("\n");
            Console.ReadLine();
        }
    }

    public class BinaryTree
    {
        public sealed class TreeNode
        {
            private int _nodevalue; //节点值
            private TreeNode _leftnode; //左子节点
            private TreeNode _rightnode; //右子节点

            //节点的构造函数
            public TreeNode(int nodevalue)
            {
                this._nodevalue = nodevalue;
                this._leftnode = null;
                this._rightnode = null;
            }

            //属性
            public int NodeValue
            {
                get
                {
                    return this._nodevalue;
                }
            }

            public TreeNode LeftNode
            {
                get
                {
                    return this._leftnode;
                }
                set
                {
                    if (this._leftnode == null)
                    {
                        if (value != null)
                        {
                            this._leftnode = value;
                        }
                        else
                        {
                            //done
                        }
                    }
                    else
                    {
                        //done
                    }
                }
            }


            public TreeNode RightNode
            {
                get
                {
                    return this._rightnode;
                }
                set
                {
                    if (this._rightnode == null)
                    {
                        if (value != null)
                        {
                            this._rightnode = value;
                        }
                        else
                        {
                            //done
                        }
                    }
                    else
                    {
                        //done
                    }
                }
            }
        }

        private TreeNode _rootnode; //二叉树的根节点

        public TreeNode RootNode
        {
            get
            {
                return this._rootnode;
            }
        }

        //二叉树的构造函数
        public BinaryTree()
        {
            this._rootnode = null;
        }

        //二叉树生成排序法--假设有一个逻辑无序的数字序列，顺序访问此序列，将所有访问到的某数据以某种规则（待插入的节点值与当前节点值比较，比当前节点值小放入左边，否则放入右边）加入二叉树，最终生成一个规则的二叉树。
        public void AddData(int num)
        {
            TreeNode node = new TreeNode(num);
            if (this._rootnode == null)
            {
                this._rootnode = node;
            }
            else //已有根节点，递归查找位置
            {
                TreeNode currentnode = this._rootnode;
                this.compareData(currentnode, node);
            }
        }

        public void compareData(TreeNode currentnode, TreeNode newnode)
        {
            if (newnode.NodeValue <= currentnode.NodeValue) //去左边查找位置
            {
                if (currentnode.LeftNode == null)
                {
                    currentnode.LeftNode = newnode; //左边空着，填入
                }
                else //左边已有节点，继续递归查找位置
                {
                    currentnode = currentnode.LeftNode;
                    this.compareData(currentnode, newnode);
                }
            }
            else //去右边查找位置
            {
                if (currentnode.RightNode == null)
                {
                    currentnode.RightNode = newnode; //右边空着，填入
                }
                else //右边已有节点，继续递归查找位置
                {
                    currentnode = currentnode.RightNode;
                    this.compareData(currentnode, newnode);
                }
            }
        }

        public void PreOrder(TreeNode node) //前序遍历
        {
            if (node != null)
            {
                Console.Write(node.NodeValue.ToString() + "\t");
                this.PreOrder(node.LeftNode);
                this.PreOrder(node.RightNode);
            }
            else
            {
                //done
            }
        }

        public void MidOrder(TreeNode node) //中序遍历
        {
            if (node != null)
            {
                this.MidOrder(node.LeftNode);
                Console.Write(node.NodeValue.ToString() + "\t");
                this.MidOrder(node.RightNode);
            }
            else
            {
                //done
            }
        }

        public void AfterOrder(TreeNode node) //后序遍历
        {
            if (node != null)
            {
                AfterOrder(node.LeftNode);
                AfterOrder(node.RightNode);
                Console.Write(node.NodeValue.ToString() + "\t");
            }
        }

        public void DepthFirst() //宽度优先遍历
        {

            Queue treequeue = new Queue();
            treequeue.Enqueue(this.RootNode);
            while (treequeue.Count > 0)
            {
                TreeNode node = (TreeNode)treequeue.Dequeue();
                Console.Write(node.NodeValue.ToString() + "\t");
                if (node.LeftNode != null)
                {
                    treequeue.Enqueue(node.LeftNode);
                }
                if (node.RightNode != null)
                {
                    treequeue.Enqueue(node.RightNode);
                }
            }
        }

        public void nonrecursivePreOrder(TreeNode node) //非递归的前序遍历
        {
            if (node != null)
            {
                Console.Write(node.NodeValue.ToString() + "\t"); //访问根节点
                Stack<TreeNode> treestack = new Stack<TreeNode>(); //初始化一个TreeNode类型的栈
                treestack.Push(node); //根节点入栈
                TreeNode temp = node.LeftNode; //访问左子树
                while (treestack.Count > 0 || temp != null)
                {
                    while (temp != null)
                    {
                        Console.Write(temp.NodeValue.ToString() + "\t");
                        treestack.Push(temp);
                        temp = temp.LeftNode;//遍历左子树
                    }
                    temp = treestack.Pop(); //直到从栈顶取出根节点
                    temp = temp.RightNode; //遍历右子树 
                }
            }
            else
            {
                //done
            }
        }

        public void nonrecursiveMidOrder(TreeNode node) //非递归的中序遍历
        {
            if (node != null)
            {
                Stack<TreeNode> treestack = new Stack<TreeNode>();
                treestack.Push(node);
                TreeNode temp = node.LeftNode;
                while (treestack.Count > 0 || temp != null)
                {
                    while (temp != null)
                    {
                        treestack.Push(temp);
                        temp = temp.LeftNode;

                    }
                    temp = treestack.Pop();
                    Console.Write(temp.NodeValue.ToString() + "\t");
                    temp = temp.RightNode;
                }
            }
            else
            {
                //done
            }
        }

        public void nonrecursiveAfterOrder(TreeNode node) //非递归的后序遍历
        {
            if (node != null)
            {
                Stack<TreeNode> treestack = new Stack<TreeNode>();
                treestack.Push(node);
                TreeNode preNode = null;
                TreeNode currNode = null;
                while (treestack.Count > 0)
                {
                    currNode = treestack.Peek();
                    if (preNode == null || preNode.LeftNode == currNode || preNode.RightNode == currNode)
                    {
                        if (currNode.LeftNode != null)
                        {
                            treestack.Push(currNode.LeftNode);
                        }
                        else if (currNode.RightNode != null)
                        {
                            treestack.Push(currNode.RightNode);
                        }
                    }
                    else if (currNode.LeftNode == preNode)
                    {
                        if (currNode.RightNode != null)
                        {
                            treestack.Push(currNode.RightNode);
                        }
                    }
                    else
                    {
                        Console.Write(currNode.NodeValue.ToString() + "\t");
                        treestack.Pop();
                    }
                    preNode = currNode;
                }
            }
            else
            {
                //done
            }
        }
    }
}
