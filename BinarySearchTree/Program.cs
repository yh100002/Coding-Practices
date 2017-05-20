using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        //http://www.geeksforgeeks.org/how-to-determine-if-a-binary-tree-is-balanced/

        class TreeNode<T>
        {
            public T Element { get; set; }
            public TreeNode<T> Left { get; set; }
            public TreeNode<T> Right { get; set; }

            public TreeNode(T element)
            {
                this.Element = element;
            }
            public override string ToString()
            {
                string nodeString = "[" + this.Element + " ";

                // Leaf node
                if (this.Left == null && this.Right == null)
                {
                    nodeString += " (Leaf) ";
                }

                if (this.Left != null)
                {
                    nodeString += "Left: " + this.Left.ToString();
                }

                if (this.Right != null)
                {
                    nodeString += "Right: " + this.Right.ToString();
                }

                nodeString += "] ";

                return nodeString;
            }

        };

        class BinarySearchTree<T>
        {
            public TreeNode<T> Root { get; set; }

            public BinarySearchTree()
            {
                this.Root = null;
            }

            public void Insert(T x)
            {
                this.Root = Insert(x, this.Root);
            }

            public void Remove(T x)
            {
                this.Root = Remove(x, this.Root);
            }

            public void RemoveMin()
            {
                this.Root = RemoveMin(this.Root);
            }

            public T FindMin()
            {
                return ElementAt(FindMin(this.Root));
            }

            public T FindMax()
            {
                return ElementAt(FindMax(this.Root));
            }

            public T Find(T x)
            {
                return ElementAt(Find(x, this.Root));
            }

            public void MakeEmpty()
            {
                this.Root = null;
            }

            public bool IsEmpty()
            {
                return this.Root == null;
            }

            private T ElementAt(TreeNode<T> t)
            {
                return t == null ? default(T) : t.Element;
            }

            private TreeNode<T> Find(T x, TreeNode<T> t)
            {
                while (t != null)
                {
                    if ((x as IComparable).CompareTo(t.Element) < 0)
                    {
                        t = t.Left;
                    }
                    else if ((x as IComparable).CompareTo(t.Element) > 0)
                    {
                        t = t.Right;
                    }
                    else
                    {
                        return t;
                    }
                }

                return null;
            }

            private TreeNode<T> FindMin(TreeNode<T> t)
            {
                if (t != null)
                {
                    while (t.Left != null)
                    {
                        t = t.Left;
                    }
                }

                return t;
            }

            private TreeNode<T> FindMax(TreeNode<T> t)
            {
                if (t != null)
                {
                    while (t.Right != null)
                    {
                        t = t.Right;
                    }
                }

                return t;
            }

            protected TreeNode<T> Insert(T x, TreeNode<T> t)
            {
                if (t == null)
                {
                    t = new TreeNode<T>(x);
                }
                else if ((x as IComparable).CompareTo(t.Element) < 0)
                {
                    t.Left = Insert(x, t.Left);
                }
                else if ((x as IComparable).CompareTo(t.Element) > 0)
                {
                    t.Right = Insert(x, t.Right);
                }
                else
                {
                    throw new Exception("Duplicate item");
                }

                return t;
            }

            protected TreeNode<T> RemoveMin(TreeNode<T> t)
            {
                if (t == null)
                {
                    throw new Exception("Item not found");
                }
                else if (t.Left != null)
                {
                    t.Left = RemoveMin(t.Left);
                    return t;
                }
                else
                {
                    return t.Right;
                }
            }

            protected TreeNode<T> Remove(T x, TreeNode<T> t)
            {
                if (t == null)
                {
                    throw new Exception("Item not found");
                }
                else if ((x as IComparable).CompareTo(t.Element) < 0)
                {
                    t.Left = Remove(x, t.Left);
                }
                else if ((x as IComparable).CompareTo(t.Element) > 0)
                {
                    t.Right = Remove(x, t.Right);
                }
                else if (t.Left != null && t.Right != null)
                {
                    t.Element = FindMin(t.Right).Element;
                    t.Right = RemoveMin(t.Right);
                }
                else
                {
                    t = (t.Left != null) ? t.Left : t.Right;
                }

                return t;
            }

            public override string ToString()
            {
                return this.Root.ToString();
            }

            public void Print()
            {
                Print(Root, 4);
            }

            public void Print(TreeNode<T> p, int padding)
            {
                if (p != null)
                {
                    if (p.Right != null)
                    {
                        Print(p.Right, padding + 4);
                    }
                    if (padding > 0)
                    {
                        Console.Write(" ".PadLeft(padding));
                    }
                    if (p.Right != null)
                    {
                        Console.Write("/\n");
                        Console.Write(" ".PadLeft(padding));
                    }
                    Console.Write(p.Element.ToString() + "\n ");
                    if (p.Left != null)
                    {
                        Console.Write(" ".PadLeft(padding) + "\\\n");
                        Print(p.Left, padding + 4);
                    }
                }
            }

            public bool IsBalanced(TreeNode<T> node)
            {
                int lh; /* for height of left subtree */
                int rh; /* for height of right subtree */

                /* If tree is empty then return true */
                if (node == null)
                    return true;

                /* Get the height of left and right sub trees */
                lh = GetHeight(node.Left);
                rh = GetHeight(node.Right);

                if (Math.Abs(lh - rh) <= 1 && IsBalanced(node.Left) && IsBalanced(node.Right))
                    return true;

                /* If we reach here then tree is not height-balanced */
                return false;
            }

            public int GetHeight(TreeNode<T> node)
            {
                /* base case tree is empty */
                if (node == null)
                    return 0;

                /* If tree is not empty then height = 1 + max of left
                 height and right heights */
                return 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
            }
        };


        static void Main(string[] args)
        {
            // Initialize a BST which will contain integers
            BinarySearchTree<int> intTree = new BinarySearchTree<int>();

            Random r = new Random(DateTime.Now.Millisecond);
            string trace = "";

            // Insert 5 random integers into the tree
            for (int i = 0; i < 5; i++)
            {
                int randomInt = r.Next(1, 1000);
                intTree.Insert(randomInt);
                trace += randomInt + " ";
            }

            //Balance checking
            Console.WriteLine(intTree.IsBalanced(intTree.Root));

            //Get Height of Tree
            Console.WriteLine(intTree.GetHeight(intTree.Root));

            // Find the largest value in the tree
            Console.WriteLine("Max: " + intTree.FindMax());

            // Find the smallest value in the tree
            Console.WriteLine("Min: " + intTree.FindMin());

            // Find the root of the tree
            Console.WriteLine("Root: " + intTree.Root.Element);

            // The order in which the elements were added to the tree
            Console.WriteLine("Trace: " + trace);

            // A textual representation of the tree
            Console.WriteLine("Tree: " + intTree);
            intTree.Print();

            Console.ReadLine();
        }
    }
}
