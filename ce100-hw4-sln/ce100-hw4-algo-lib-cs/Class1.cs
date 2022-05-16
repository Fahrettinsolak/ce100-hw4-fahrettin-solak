using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* @file ce100_hw3_algo_lib_cs *
* @author Fahrettin SOLAK *
* @date 10 April 2022 * 
*
* @brief <b> hw-3 Functions </b> *
*
* HW-3 Sample Lib Functions *
*
* @see http://bilgisayar.mmf.erdogan.edu.tr/en/
*
*/

namespace ce100_hw4_algo_lib_cs
{




    public class Activity_Selection
    {

        /**
        *
        *	  @name   printMaxActivities (Print Activity Selection Problem)
        *
        *	  @brief Print Activity Selection Problem
        *
        *	  Print Activity Selection Problem
        *
        *	  @param  [in] s [\b int]  s
        *	  
        *	  @param  [in] f [\b int]  f
        *	  
        *	  @param  [in] n [\b int]  n
        *	  
        *	  
        **/

        public static int printMaxActivities(int[] s, int[] f, int n)
        {
            int i, j;

            i = 0;

            for (j = 1; j < n; j++)
            {
                if (s[j] >= f[i])
                {
                    i = j;
                }
            }
            return i;
        }

    }

    public class Knapsack_Problem
    {
        public static int max(int a, int b)
        {
            return (a > b) ? a : b;
        }
        /**
        *
        *	  @name   knapSack (Knapsack Function)
        *
        *	  @brief Knapsack Function
        *
        *	  Knapsack Function
        *
        *	  @param  [in] W [\b int]  W
        *	  
        *	  @param  [in] wt [\b int]  wt
        *	  
        *	  @param  [in] val [\b int]  val
        *	  
        *	  @param  [in] n [\b int]  n
        *	  
        *	  
        **/


        public static int knapSack(int W, int[] wt, int[] val, int n)
        {

            // Base Case
            if (n == 0 || W == 0)
                return 0;
            if (wt[n - 1] > W)
                return knapSack(W, wt,
                                val, n - 1);
            else
                return max(val[n - 1]
                           + knapSack(W - wt[n - 1], wt,
                                      val, n - 1),
                           knapSack(W, wt, val, n - 1));
        }


        /**
        *
        *	  @name   knapSack (Print Knapsack Function)
        *
        *	  @brief Print Knapsack Function
        *
        *	  Print Knapsack Function
        *
        *	  @param  [in] W [\b int]  W
        *	  
        *	  @param  [in] wt [\b int]  wt
        *	  
        *	  @param  [in] val [\b int]  val
        *	  
        *	  @param  [in] n [\b int]  n
        *	  
        *	  
        **/

        public static int printknapSack(int W, int[] wt, int[] val, int n)
        {
            int i, w;
            int[,] K = new int[n + 1, W + 1];

            for (i = 0; i <= n; i++)
            {
                for (w = 0; w <= W; w++)
                {
                    if (i == 0 || w == 0)
                        K[i, w] = 0;
                    else if (wt[i - 1] <= w)
                        K[i, w] = Math.Max(val[i - 1] +
                                K[i - 1, w - wt[i - 1]], K[i - 1, w]);
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            int res = K[n, W];

            w = W;
            for (i = n; i > 0 && res > 0; i--)
            {

                if (res == K[i - 1, w])
                    continue;
                else
                {

                    res = res - val[i - 1];
                    w = w - wt[i - 1];
                }
            }
            return res;
        }

    }

    public class BFS_Problem
    {
    
        public static int _v;

        public static LinkedList<int>[] _adj;

        public static void Graph(int V)
        {
            _adj = new LinkedList<int>[V];
            for (int i = 0; i < _adj.Length; i++)
            {
                _adj[i] = new LinkedList<int>();
            }
            _v = V;
        }

        public static void AddEdge(int v, int w)
        {
            _adj[v].AddLast(w);

        }

        /**
        *
        *	  @name   BFS (BFS Function)
        *
        *	  @brief BFS Function
        *
        *	  BFS Function
        *
        *	  @param  [in] s [\b int]  s
        *	  
        **/
        public static string BFS(int s)
        {
            string arr = "";
            bool[] visited = new bool[_v];
            for (int i = 0; i < _v; i++)
                visited[i] = false;

            LinkedList<int> queue = new LinkedList<int>();

            visited[s] = true;
            queue.AddLast(s);

            while (queue.Any())
            {

                s = queue.First();
                arr += (s + ",");
                queue.RemoveFirst();

                LinkedList<int> list = _adj[s];


                foreach (var val in list)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.AddLast(val);
                    }
                }
            }
            return arr.Remove(arr.Length - 2);
        }


    }

    public class DFS_Problem
    {

        public static int _V;
                           
        public static LinkedList<int>[] adj;

        public static void graph(int V)
        {

            adj = new LinkedList<int>[V];

            for (int i = 0; i < adj.Length; i++)
            {
                adj[i] = new LinkedList<int>();
            }
            _V = V;
        }

        public static void addEdge(int v, int w)
        {
            adj[v].AddLast(w);
        }

        /**
        *
        *	  @name   DFS_Print (Print DFS Function)
        *
        *	  @brief Print DFS Function
        *
        *	  Print DFS Function
        *
        *	  @param  [in] s [\b int]  s
        *	  
        *	  
        **/

        public static string DFS_Print(int s)
        {
            Boolean[] visited = new Boolean[_V];

            Stack<int> stack = new Stack<int>();
            stack.Push(s);
            string print = "";
            while (stack.Count > 0)
            {
                s = stack.Peek();
                stack.Pop();

                if (visited[s] == false)
                {
                    print += s + ", ";
                    visited[s] = true;
                }

                foreach (int v in adj[s])
                {
                    if (!visited[v])
                        stack.Push(v);
                }

            }

            return print.Remove(print.Length - 2);
        }

    }

    public class Topological_Sort_Problem
    {

        public static int V;

        public static List<List<int>> adjacency;

        public static void _graph(int v)
        {
            V = v;
            adjacency = new List<List<int>>(v);
            for (int i = 0; i < v; i++)
                adjacency.Add(new List<int>());
        }

        public static void addedge(int v, int w)
        {
            adjacency[v].Add(w);
        }

       /**
       *
       *	  @name   TopologicalSortUtil (Topological Sort Function)
       *
       *	  @brief Topological Sort Function
       *
       *	  Topological Sort Function
       *
       *	  @param  [in] v [\b int]  v
       *	  
       *	  @param  [in] visited [\b int]  visited
       *	  
       *	  @param  [in] stack [\b int]  stack
       *	  
       *	  
       **/

        public static void TopologicalSortUtil(int v, bool[] visited, Stack<int> stack)
        {

            visited[v] = true;

            foreach (var vertex in adjacency[v])
            {
                if (!visited[vertex])
                    TopologicalSortUtil(vertex, visited, stack);
            }

            stack.Push(v);
        }

        public static string TopologicalSort()
        {
            Stack<int> stack = new Stack<int>();

            var visited = new bool[V];
            string print = "";

            for (int i = 0; i < V; i++)
            {
                if (visited[i] == false)
                    TopologicalSortUtil(i, visited, stack);
            }

            foreach (var vertex in stack)
            {
                print += vertex + ", ";
            }

            return print.Remove(print.Length - 2);

        }

    }

    public class SCC_Problem
    {
        /**
       *
       *	  @name   SCCProblem (SCC Function)
       *
       *	  @brief SCC Function
       *
       *	  SCC Function
       *
       *	  @param  [in] v [\b int]  v
       *	  
       *	  
       **/

        public int V;
        public LinkedList<int>[] adj;
        public int Time;
        public void addEdge(int v, int w)
        {
            adj[v].AddLast(w);
        }
        public SCC_Problem(int v)
        {
            V = v;
            adj = new LinkedList<int>[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new LinkedList<int>();
            }
        }
        public void SCCUtil(int u, int[] low, int[] disc, bool[] stackMember, Stack<int> stack)
        {
            low[u] = disc[u] = Time++;
            stack.Push(u);
            stackMember[u] = true;
            foreach (int v in adj[u])
            {
                if (disc[v] == -1)
                {
                    SCCUtil(v, low, disc, stackMember, stack);
                    low[u] = Math.Min(low[u], low[v]);
                }
                else if (stackMember[v])
                {
                    low[u] = Math.Min(low[u], disc[v]);
                }
            }
            if (low[u] == disc[u])
            {
                int v;
                do
                {
                    v = stack.Pop();
                    Console.WriteLine(v + " ");
                    stackMember[v] = false;
                } while (v != u);
            }
        }
        public int SCC()
        {
            int[] low = new int[V];
            int[] disc = new int[V];
            bool[] stackMember = new bool[V];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < V; i++)
            {
                disc[i] = -1;
                low[i] = -1;
            }
            for (int i = 0; i < V; i++)
            {
                if (disc[i] == -1)
                {
                    SCCUtil(i, low, disc, stackMember, stack);
                }
            }
            return 0;
        }

    }
}