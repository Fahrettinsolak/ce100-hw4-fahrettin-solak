using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw4_algo_lib_cs;
namespace ce100_hw4_algo_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Activity_Selection_Test_1()
        {
            int[] s4 = { 12, 32, 02, 52, 82, 52 };

            int[] f4 = { 22, 42, 62, 72, 92, 94 };
            int n = s4.Length;

            int act = Activity_Selection.printMaxActivities(s4, f4, n);
            int result = 4;
            Assert.AreEqual(act, result);
        }

        [TestMethod]
        public void Activity_Selection_Test_2()
        {
            int[] s4 = { 48907, 458903, 120983, 78689035, 1809, 88905 };

            int[] f4 = { 48907, 64518903, 2128903, 788909, 23809, 18092 };
            int n = s4.Length;

            int act = Activity_Selection.printMaxActivities(s4, f4, n);
            int result = 3;
            Assert.AreEqual(act, result);
        }

        [TestMethod]
        public void Activity_Selection_Test_3()
        {
            int[] s4 = { 658903, 68905, 648905, 879809, 189032, 658093 };

            int[] f4 = { 89489065, 6589013, 5368907, 148907, 58901, 58904 };
            int n = s4.Length;

            int act = Activity_Selection.printMaxActivities(s4, f4, n);
            int res = 0;
            Assert.AreEqual(act, res);
        }

        [TestMethod]
        public void Knapsack_test_1()
        {
            int[] val = new int[] { 6000, 10000, 12000 };
            int[] wt = new int[] { 1000, 2000, 3000 };
            int W = 5000;
            int n = val.Length;

            int actual = Knapsack_Problem.knapSack(W, wt, val, n);
            int res = 22000;
            Assert.AreEqual(actual, res);
        }

        [TestMethod]
        public void Knapsack_test_2()
        {
            int[] val = new int[] { 100, 300, 400, 500, 600 };
            int[] wt = new int[] { 100, 200, 300, 400, 500 };
            int W = 800;
            int n = val.Length;

            int actual = Knapsack_Problem.knapSack(W, wt, val, n);
            int res = 1000;
            Assert.AreEqual(actual, res);
        }

        [TestMethod]
        public void Knapsack_test_3()
        {
            int[] val = new int[] { 4000, 2500, 8700, 1300 };
            int[] wt = new int[] { 1500, 3400, 1200, 4700 };
            int W = 7500;
            int n = val.Length;

            int actual = Knapsack_Problem.knapSack(W, wt, val, n);
            int res = 15200;
            Assert.AreEqual(actual, res);
        }

        [TestMethod]
        public void Knapsack_Print_test_1()
        {
            int[] val = { 6000, 10000, 12000 };
            int[] wt = { 1000, 2000, 3000 };
            int W = 5000;
            int n = val.Length;

            int actual = Knapsack_Problem.printknapSack(W, wt, val, n);
            int res = 000;
            Assert.AreEqual(actual, res);
        }

        [TestMethod]
        public void Knapsack_Print_test_2()
        {
            int[] val = new int[] { 100, 300, 400, 500, 600 };
            int[] wt = new int[] { 100, 200, 300, 400, 500 };
            int W = 800;
            int n = val.Length;

            int actual = Knapsack_Problem.printknapSack(W, wt, val, n);
            int res = 000;
            Assert.AreEqual(actual, res);
        }

        [TestMethod]
        public void Knapsack_Print_test_3()
        {
            int[] val = new int[] { 4000, 2500, 8700, 1300 };
            int[] wt = new int[] { 1500, 3400, 1200, 4700 };
            int W = 7500;
            int n = val.Length;

            int res = Knapsack_Problem.printknapSack(W, wt, val, n);
            int exp = 000;
            Assert.AreEqual(res, exp);
        }

        [TestMethod]
        public void BFS_test_1()
        {
            BFS_Problem.Graph(4);

            BFS_Problem.AddEdge(0, 1);
            BFS_Problem.AddEdge(0, 2);
            BFS_Problem.AddEdge(1, 2);
            BFS_Problem.AddEdge(2, 0);
            BFS_Problem.AddEdge(2, 3);
            BFS_Problem.AddEdge(3, 3);

            int s = 2;
            string result = "2,0,3,";
            Assert.AreEqual(BFS_Problem.BFS(s), result);
        }

        [TestMethod]
        public void BFS_test_2()
        {
            BFS_Problem.Graph(6);

            BFS_Problem.AddEdge(0, 1);
            BFS_Problem.AddEdge(0, 2);
            BFS_Problem.AddEdge(1, 2);
            BFS_Problem.AddEdge(1, 3);
            BFS_Problem.AddEdge(2, 0);
            BFS_Problem.AddEdge(2, 3);
            BFS_Problem.AddEdge(3, 3);
            BFS_Problem.AddEdge(3, 4);
            BFS_Problem.AddEdge(4, 0);
            BFS_Problem.AddEdge(4, 1);
            BFS_Problem.AddEdge(4, 5);

            int s = 0;
            string result = "0,1,2,3,4,";
            Assert.AreEqual(BFS_Problem.BFS(s), result);
        }

        [TestMethod]
        public void BFS_test_3()
        {
            BFS_Problem.Graph(8);

            BFS_Problem.AddEdge(0, 1);
            BFS_Problem.AddEdge(0, 2);
            BFS_Problem.AddEdge(1, 2);
            BFS_Problem.AddEdge(2, 0);
            BFS_Problem.AddEdge(2, 3);
            BFS_Problem.AddEdge(3, 4);
            BFS_Problem.AddEdge(5, 4);
            BFS_Problem.AddEdge(5, 6);
            BFS_Problem.AddEdge(7, 6);

            int s = 0;
            string result = "0,1,2,3,";
            Assert.AreEqual(BFS_Problem.BFS(s), result);
        }

        [TestMethod]
        public void DFS_test_1()
        {
            DFS_Problem.graph(4);

            DFS_Problem.addEdge(0, 1);
            DFS_Problem.addEdge(1, 3);
            DFS_Problem.addEdge(0, 2);
            DFS_Problem.addEdge(2, 0);
            DFS_Problem.addEdge(2, 1);
            DFS_Problem.addEdge(0, 3);



            int s = 2;
            string result = "2, 1, 3, 0";
            Assert.AreEqual(DFS_Problem.DFS_Print(s), result);
        }

        [TestMethod]

        public void DFS_test_2()
        {
            DFS_Problem.graph(4);

            DFS_Problem.addEdge(0, 1);
            DFS_Problem.addEdge(1, 3);
            DFS_Problem.addEdge(0, 2);
            DFS_Problem.addEdge(2, 0);
            DFS_Problem.addEdge(2, 1);
            DFS_Problem.addEdge(0, 3);


            int s = 0;
            string result = "0, 3, 2, 1";
            Assert.AreEqual(DFS_Problem.DFS_Print(s), result);
        }

        [TestMethod]

        public void DFS_test_3()
        {
            DFS_Problem.graph(5);

            DFS_Problem.addEdge(0, 2);
            DFS_Problem.addEdge(2, 1);
            DFS_Problem.addEdge(0, 3);
            DFS_Problem.addEdge(3, 4);



            int s = 0;
            string result = "0, 3, 4, 2, 1";
            Assert.AreEqual(DFS_Problem.DFS_Print(s), result);
        }

        [TestMethod]
        public void Topological_Sort_Problem_Test_1()
        {
            Topological_Sort_Problem._graph(6);
            Topological_Sort_Problem.addedge(5, 2);
            Topological_Sort_Problem.addedge(5, 0);
            Topological_Sort_Problem.addedge(4, 0);
            Topological_Sort_Problem.addedge(4, 1);
            Topological_Sort_Problem.addedge(2, 3);
            Topological_Sort_Problem.addedge(3, 1);


            string act = Topological_Sort_Problem.TopologicalSort();
            string res = "5, 4, 2, 3, 1, 0";
            Assert.AreEqual(act, res);
        }

        [TestMethod]
        public void Topological_Sort_Problem_Test_2()
        {
            Topological_Sort_Problem._graph(6);
            Topological_Sort_Problem.addedge(5, 2);
            Topological_Sort_Problem.addedge(5, 0);
            Topological_Sort_Problem.addedge(4, 0);
            Topological_Sort_Problem.addedge(4, 1);
            Topological_Sort_Problem.addedge(2, 3);
            Topological_Sort_Problem.addedge(3, 1);


            string act = Topological_Sort_Problem.TopologicalSort();
            string res = "5, 4, 2, 3, 1, 0";
            Assert.AreEqual(act, res);
        }

        [TestMethod]
        public void Topological_Sort_Problem_Test_3()
        {
            Topological_Sort_Problem._graph(6);
            Topological_Sort_Problem.addedge(5, 2);
            Topological_Sort_Problem.addedge(5, 0);
            Topological_Sort_Problem.addedge(4, 0);
            Topological_Sort_Problem.addedge(4, 1);
            Topological_Sort_Problem.addedge(2, 3);
            Topological_Sort_Problem.addedge(3, 1);


            string act = Topological_Sort_Problem.TopologicalSort();
            string res = "5, 4, 2, 3, 1, 0";
            Assert.AreEqual(act, res);
        }

        [TestMethod]
        public void SCCProblemtest()
        {
            SCC_Problem g = new SCC_Problem(3);
            g.addEdge(0, 1);
            g.addEdge(1, 2);
            int result = g.SCC();
            SCC_Problem g1 = new SCC_Problem(3);
            g1.addEdge(0, 1);
            g1.addEdge(1, 2);
            int expected = g1.SCC();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SCC_test_2()
        {
            SCC_Problem g = new SCC_Problem(4);
            g.addEdge(0, 1);
            g.addEdge(1, 2);
            g.addEdge(2, 3);
            int result = g.SCC();
            SCC_Problem g1 = new SCC_Problem(4);
            g1.addEdge(0, 1);
            g1.addEdge(1, 2);
            g1.addEdge(1, 3);
            int expected = g1.SCC();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SCC_test_3()
        {
            SCC_Problem g = new SCC_Problem(5);
            g.addEdge(0, 1);
            g.addEdge(1, 2);
            g.addEdge(2, 3);
            g.addEdge(3, 2);
            int result = g.SCC();
            SCC_Problem g1 = new SCC_Problem(5);
            g1.addEdge(0, 1);
            g1.addEdge(1, 2);
            g1.addEdge(2, 3);
            g1.addEdge(3, 4);
            int expected = g1.SCC();
            Assert.AreEqual(expected, result);
        }
    }
}
