using System.Collections.Generic;
using System.Text;

namespace DavidMath{
    public class BinarySearchTree {
        private Leaf head;

        public BinarySearchTree(){ }

        public void Add(int a){
            if (head == null)
                head = new Leaf(a);
            else
                head.Add(a);
        }

        public void Remove(int a){
            if (Contains(a)){
                if (head.Childless())
                    head = null;
                else{
                    head.Remove(a);
                }
            }
        }

        public bool Contains(int a){
            if (head != null)
                return head.Contains(a);
            return false;
        }

        public List<int> OrderedList(){
            if (head != null)
                return head.TreeOrderedList();
            return new List<int>();
        }

        public override string ToString(){
            if (head != null)
                return head.ToString();
            return "";
        }

        private class Leaf {
            private int value;
            private Leaf leftLeaf;
            private Leaf rightLeaf;
            public Leaf(int a) {
                value = a;
            }

            public bool Contains(int a) {
                if (a > value && rightLeaf != null)
                    return rightLeaf.Contains(a);
                if (a < value && leftLeaf != null)
                    return leftLeaf.Contains(a);
                return value == a;
            }

            public void Add(int a) { //Does nothing if the BST already contains that value.
                if (a > value) {
                    if (rightLeaf == null)
                        rightLeaf = new Leaf(a);
                    else
                        rightLeaf.Add(a);
                }
                if (a < value) {
                    if (leftLeaf == null)
                        leftLeaf = new Leaf(a);
                    else
                        leftLeaf.Add(a);
                }
            }

            public void Remove(int a){
                if (Contains(a)){
                    if(a > value){
                        if (!rightLeaf.Childless())
                            rightLeaf.Remove(a);
                        else
                            rightLeaf = null;
                    }
                    else if( a < value){
                        if(!leftLeaf.Childless())
                            leftLeaf.Remove(a);
                        else
                            leftLeaf = null;
                    }
                    else{
                        if(LeftSuccessor() != value){
                            int temp = LeftSuccessor();
                            Remove(temp);
                            value = temp;
                        }else{
                            int temp = RightSuccessor();
                            Remove(temp);
                            value = temp;
                        }
                    }
                }
            }

            private int LeftSuccessor(){
                if (leftLeaf != null)
                    return leftLeaf.LeftSuccessor();
                return value;
            }

            private int RightSuccessor(){
                if (rightLeaf != null)
                    return rightLeaf.RightSuccessor();
                return value;
            }

            public List<int> TreeOrderedList() {
                List<int> holder = new List<int>();
                if (leftLeaf != null)
                    holder.AddRange(leftLeaf.TreeOrderedList());
                holder.Add(value);
                if (rightLeaf != null) {
                    holder.AddRange(rightLeaf.TreeOrderedList());
                }
                return holder;
            }

            public override string ToString() {
                StringBuilder x = new StringBuilder();
                if (leftLeaf != null)
                    x.Append(leftLeaf.ToString());
                x.Append(value);
                if (rightLeaf != null)
                    x.Append(rightLeaf.ToString());

                return x.ToString();
            }

            public bool Childless(){
                return leftLeaf == null && rightLeaf == null;
            }
        }
    }
}
