using System.Collections.Generic;

namespace DavidMath{
    public class BinarySearchTree{
        private int value;
        private BinarySearchTree leftNode;
        private BinarySearchTree rightNode;
        public BinarySearchTree(int a){
            value = a;
        }

        public bool contains(int a){
            if (a > value && rightNode != null)
                return rightNode.contains(a);
            if (a < value && leftNode != null)
                return leftNode.contains(a);
            return value == a;
        }

        public void add(int a){
            if (a > value)
                set(rightNode, a);
            else if (a < value)
                set(leftNode, a);
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

        private void set(BinarySearchTree b, int a){
            if (b == null)
                b = new BinarySearchTree(a);
            else
                b.add(a);
        }
    }
}
