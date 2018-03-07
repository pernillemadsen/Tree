using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class Tree<T>
    {
        // The root of the tree
        public TreeNode<T> root;

        /// <summary>Constructs the tree</summary>
        /// <param name="value">the value of the node</param>
        public Tree(T value)
        {
            if (value != null)
                this.root = new TreeNode<T>(value);
        }

        public void BreadthFirstSearch()
        {
            //create new queue
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            //put root in queue
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                //get first item of queue
                TreeNode<T> v = queue.Dequeue();
                Console.WriteLine(v.value);
                foreach (TreeNode<T> c in v.children)
                {
                    queue.Enqueue(c);
                }
            }
        }

        public void DepthFirsthSearch()
        {
            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
            stack.Push(root);
            while (stack.Count != 0)
            {
                TreeNode<T> v = stack.Pop();
                Console.WriteLine(v.value);
                foreach(TreeNode<T> c in v.children)
                {
                    stack.Push(c);
                }
            }
        }
    }
}