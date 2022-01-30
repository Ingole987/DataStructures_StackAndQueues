// See https://aka.ms/new-console-template for more information
using StacksAndQueues;

Console.WriteLine("Hello World!");
//StackUsingLinkedList linkedListStack = new StackUsingLinkedList();
//linkedListStack.Push(70);
//linkedListStack.Push(30);
//linkedListStack.Push(56);
//linkedListStack.Display();
//linkedListStack.Peek(); top.data
//linkedListStack.Pop();
//linkedListStack.IsEmpty();
//linkedListStack.Display();
Queue linkedListQueues = new Queue();
linkedListQueues.Enqueue(56);
linkedListQueues.Enqueue(30);
linkedListQueues.Enqueue(70);
linkedListQueues.Display();
Console.WriteLine("------------------");
linkedListQueues.Dequeue();
linkedListQueues.Display();
Console.ReadKey();