using System.Collections.Generic;
using System.Text;
namespace DavidMath {
    public class SinglyLinkedList {
        private Node head;

        public SinglyLinkedList() {}

        public void Add(int a){
            if (head == null)
                head = new Node(a, null);
            else{
                if(head.value > a){
                    Node newHead = new Node(a, head);
                    head = newHead;
                }else
                    head.Add(a);
            }
        }

        public override string ToString(){
            return head.ToString();
        }

        public bool Contains(int a){
            return head.Contains(a);
        }

        public List<int> ReasonableList(){
            if(head != null)
                return head.ReasonableList();
            return new List<int>();
        }

        private class Node{
            public int value { get; private set; }
            private Node tail;

            public Node(int a, Node b){ 
                value = a;
                tail = b;
            }

            public void Add(int a){
                if (tail == null)
                    tail = new Node(a, null);
                if (tail.value > a){
                    Node newTail = new Node(a, tail);
                    tail = newTail;
                }
                else
                    tail.Add(a);
            }

            public bool Contains(int a){
                if (value == a)
                    return true;
                if (tail != null)
                    return tail.Contains(a);
                return false;
            }

            public override string ToString(){
                StringBuilder x = new StringBuilder();
                x.Append(value);
                x.Append(tail.ToString());
                return x.ToString();
            }

            public List<int> ReasonableList(){
                List<int> holder = new List<int>();
                holder.Add(value);
                if (tail != null)
                    holder.AddRange(tail.ReasonableList());
                return holder;
            }
        }
    }
}
