using System;

namespace Array_To_BST
{
    class Program
    {
        class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        class BinarySearchTree
        {
            public Node Root { get; set; }
            
            public void PrintTreePreOrder(Node root)
            {
                if (root != null)
                {
                    Console.WriteLine(root.Data);
                    PrintTreePreOrder(root.Left);
                    PrintTreePreOrder(root.Right);
                }
            }

            public Node ArrayToBTS(int[] arr, int start, int end)
            {
                if (start > end)
                {
                    return null;
                }
                int mid;
                if ((start + end) % 2 == 0)
                {
                    mid = (start + end) / 2;
                }
                else
                {
                    mid = (start + end + 1) / 2;
                }


                Node root = new Node(arr[mid]);
                root.Left = ArrayToBTS(arr, start, mid - 1);
                root.Right = ArrayToBTS(arr, mid + 1, end);

                return root;
            }
        }

        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            int[] arr = { 1, 2, 3, 4, 5, 6, 7,8 };
            Node root = bst.ArrayToBTS(arr, 0, arr.Length - 1);
            bst.PrintTreePreOrder(root);
        }
    }
}
