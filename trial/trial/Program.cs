using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace trial
{
    class Program
    {
        static void Main(string[] args)
        {
            var SLL = new SinglyLinkedList<int>();
            
           
            SLL.AddLast(10);
            SLL.AddLast(20);
            SLL.AddLast(30);

            SLL.AddLast(40);
            SLL.AddLast(50);
            SLL.AddLast(60);
           
            Console.WriteLine("List head is at : " + SLL.Head.Value);
            PrintOutLinkedList(SLL.Head);
            /*      Node<int> temp = SLL.Head.Next.Next;
                  Console.WriteLine("Loop starts at : " + temp.Value);
                  SLL.Tail.Next = temp;*/
            SLL.ReverseList(SLL);
            // was creating a loop
                                                //    int data=  SLL.AccessDataAt(3);
                                                // Console.WriteLine("Number 3 element is: " + data); 
                                                //      Console.WriteLine("Data at 3 is : " + data);

            SLL.DetectLoop();
            /*---------------------Printing Middle Value------------------------------------------
                        var SLL = new SinglyLinkedList<int>();
                        SLL.AddFirst(1);
                        SLL.AddFirst(2);
                        SLL.AddFirst(3);
                        SLL.AddFirst(4);

                        SLL.AddFirst(5);
                        SLL.AddFirst(6);
                        SLL.AddFirst(7);
                        SLL.AddFirst(8);
                        SLL.AddFirst(9);




                        Console.WriteLine("Should print Middle value : " + SLL.PrintMiddle());
            ----------------------------------------END OF PRINTING MIDDLE VALUE---------------------------------------

                        /*  var stack = new ArrayStack<int>();
                          stack.Push(1);
                          stack.Push(2);
                          stack.Push(3);
                          stack.Push(4);
                          Console.WriteLine("Should print 4 : " + stack.Peek());
                          stack.Pop();
                          stack.Pop();
                          Console.WriteLine("Should print 2 : " + stack.Peek());
                          stack.Push(3);
                          stack.Push(4);
                          Console.WriteLine("These are the elements");
                          foreach (var i in stack)
                          {
                              Console.WriteLine(i);
                          }

                          /*   Node<int> First = new Node<int>() { Value = 5 };
                             Node<int> Second = new Node<int>() { Value = 10 };
                             First.Next = Second;
                             Node<int> Third = new Node<int>() { Value = 15 };
                             Second.Next = Third;
                             PrintOutLinkedList(First);




                             Console.Read();
                           /*  string msg = "My father is a great cook";
                             string message = msg.Insert(20, "er");
                             Console.WriteLine(message);
                             string[] strArray = msg.Split(' ');
                             foreach(string str in strArray)
                             {
                                 Console.WriteLine("" + str);
                             }
                             Console.WriteLine("String in reverse order :");
                             for(int i = strArray.Length - 1; i >= 0; i--)
                             {
                                 Console.Write("" + strArray[i]+" ");
                             } */


        }
        public static void PrintOutLinkedList(Node<int> Node)
        {
            while (Node != null)
            {
                Console.WriteLine(Node.Value);
                Node = Node.Next;

            }
        }
    }

    
}
