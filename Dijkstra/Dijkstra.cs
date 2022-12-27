
namespace Dijkstra
{
    public class Dijkstra
    {
        private Node _startNode;
        private HashSet<int> _settledNodes;
        private List<List<Node>> _adj;
        private int _v;
        private PriorityQueue<Node, double> PQ;
        
        //demo change
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v">Count of nodes of graph</param>
        /// <param name="startNode">Start Node that we want to find shortest path from here</param>
        /// <param name="adj">Repersent Graph as List of Linked nodes with distances (weights)</param>
        public Dijkstra(int v, Node startNode, List<List<Node>> adj)
        {
            _v = v;
            _startNode = startNode;
            _settledNodes = new HashSet<int>();
            _adj = adj;

            PQ = new PriorityQueue<Node, double>(v);
        }

        
    //This is my change
        public double[] ExeucteAlgorithm()
        {
            var finalDistances = new double[_v];

            for (int i = 0; i < _v; i++)
                finalDistances[i] = double.MaxValue;

            // Add source node to the priority queue
            PQ.Enqueue(_startNode, 0);

            // Distance to the source is 0
            finalDistances[_startNode.Index] = 0;

            while (_settledNodes.Count != _v)
            {
                // Terminating condition check when
                // the priority queue is empty, return
                if (PQ.Count == 0)
                    break;

                // Removing the minimum distance node
                // from the priority queue
                var node = PQ.Dequeue();

                // Adding the node whose distance is
                // finalized
                if (_settledNodes.Contains(node.Index))
                    // Continue keyword skips execution for
                    // following check
                    continue;

                // We don't have to call e_Neighbors(u)
                // if u is already present in the settled set.
                _settledNodes.Add(node.Index);

                Neighbours(node, finalDistances);
            }

            return finalDistances;
        }

        /// <param name="node">Choosen node</param>
        /// <param name="finalDistances">Final destination</param>S
        private void Neighbours(Node node, double[] finalDistances)
        {
            double newDistance = -1;

            var index = node.Index;
            // All the neighbors of v
            for (int i = 0; i < _adj[index].Count; i++)
            {
                Node linkedNode = _adj[index][i];

                // If current node hasn't already been processed
                if (!_settledNodes.Contains(linkedNode.Index))
                {
                    newDistance = finalDistances[index] + linkedNode.EdgeCost;

                    // If new distance is cheaper in cost
                    if (newDistance < finalDistances[linkedNode.Index])
                        finalDistances[linkedNode.Index] = newDistance;

                    // Add the current node to the queue
                    PQ.Enqueue(linkedNode, finalDistances[index]);
                }
            }
        }

        public class Node
        {
            // Member variables of this class
            public string Name;
            public int Index;
            public double EdgeCost;

            // Constructor 2
            public Node(string name, int index, double cost)
            {
                Name = name;
                Index = index;
                EdgeCost = cost;
            }
        }
    }
}
