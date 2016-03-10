using System.Collections.Generic;
namespace DavidMath {
    public class SinglyLinkedList {
        private node head;

        public SinglyLinkedList() { }

        public void add(int a){
            if (head != null)
                head.add(a);
            else
                head = new node(a, null);
        }

        public List<int> reasonableList(){
            if(head != null)
                return head.reasonableList();
            return new List<int>();
        }
    }

    class node{
        private int value;
        private node tail;

        public node(int a, node b){
            value = a;
            tail = b;
        }

        public void add(int a){
            if (tail == null)
                tail = new node(a, null);
            tail.add(a);
        }

        public List<int> reasonableList(){
            List<int> holder = new List<int>();
            holder.Add(value);
            if (tail != null)
                holder.AddRange(tail.reasonableList());
            return holder;
        }
    }
}
