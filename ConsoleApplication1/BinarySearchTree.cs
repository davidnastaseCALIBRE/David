using System.Collections.Generic;
using System.Text;

namespace DavidMath{
    public class BinarySearchTree{
        private int value;
        private BinarySearchTree leftNode;
        private BinarySearchTree rightNode;
        public BinarySearchTree(int a){
            value = a;
        }

        public bool Contains(int a){
            if (a > value && rightNode != null)
                return rightNode.Contains(a);
            if (a < value && leftNode != null)
                return leftNode.Contains(a);
            return value == a;
        }

        public void Add(int a){ //Does nothing if the BST already contains that value.
            if (a > value){
                if (rightNode == null)
                    rightNode = new BinarySearchTree(a);
                else
                    rightNode.Add(a);
            }
            if (a < value){
                if (rightNode == null)
                    rightNode = new BinarySearchTree(a);
                else
                    rightNode.Add(a);
            }
        }

        //Yussss recursion
        public List<int> treeOrderedList(){
            List<int> holder = new List<int>();
            if (leftNode != null)
                holder.AddRange(leftNode.treeOrderedList());
            holder.Add(value);
            if(rightNode != null){
                holder.AddRange(rightNode.treeOrderedList());
            }
            return holder;
        }

        public override string ToString(){
            StringBuilder x = new StringBuilder();
            if (leftNode != null)
                x.Append(leftNode.ToString());
            x.Append(value);
            if (rightNode != null)
                x.Append(rightNode.ToString());
     
            return x.ToString();
        }
    }
}
