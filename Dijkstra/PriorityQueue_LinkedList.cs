// C# code to implement Priority Queue
// using Linked List

using System.Collections;
using PriorityQueues;
using static Dijkstra.Dijkstra;

namespace Dijkstra
{
    class PriorityQueue_LinkedList : IPriorityQueue<Node, double>
    {
        // Node
        public class ListNode : IPriorityQueueEntry<Node>
        {
            public Node Item { get; private set; }

            // Lower values indicate
            // higher priority
            public double Priority { get; internal set; }

            public ListNode(Node item, double priority)
            {
                Item = item;
                Priority = priority;
            }
        }

        public List<ListNode> ListNodes= new List<ListNode>();

        public int Count => ListNodes.Count;

        public Node Peek => throw new NotImplementedException();

        public double PeekPriority => throw new NotImplementedException();

        public IPriorityQueueEntry<Node> Enqueue(Node item, double priority)
        {
            var listNode = new ListNode(item, priority);

            ListNodes.Add(listNode);

            return listNode;
        }

        public Node Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Linked List is empty!");
            }

            var listNode = ListNodes.OrderBy(x => x.Priority).First();

            ListNodes.Remove(listNode);

            return listNode.Item;
        }

        public void UpdatePriority(IPriorityQueueEntry<Node> entry, double priority)
        {
            throw new NotImplementedException();
        }

        public void Remove(IPriorityQueueEntry<Node> entry)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            ListNodes.Clear();
        }

        public IEnumerator<Node> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}