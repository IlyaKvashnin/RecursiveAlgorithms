using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTowers
{
    class Solver
    {
        public List<Move> Moves { get; set; } = new List<Move>();
        public List<Move> SolveHanoiRecursive(int DiskCount) {//Solver method
            //var timer = new Stopwatch();
            //List<string> milliSec = new();
            //for (int j = 1; j <=5; j++)
            //{
            //    for (int i = 1; i <= 20; i++)
            //    {
            //        Moves.Clear();
            //        timer.Start();

            //        //moveDisk(DiskCount, 1, 3, 2);
            //        moveDiskRecursive(i, 1, 3, 2);

            //        timer.Stop();
            //        milliSec.Add(timer.Elapsed.TotalMilliseconds.ToString());
            //        timer.Reset();

            //    }
            //    File.WriteAllLines($"..//..//..//result/result_{j}.txt", milliSec);

            //    milliSec.Clear();
            //}
            Moves.Clear();
            moveDiskRecursive(DiskCount, 1, 3, 2);

            return Moves;
        }
        public void moveDiskRecursive(int n, int from, int to, int on)
        {
            if (n == 1)
            {
                Moves.Add(new Move(from, to));
            }
            else
            {
                moveDiskRecursive(n - 1, from, on, to);
                moveDiskRecursive(1, from, to, on);
                moveDiskRecursive(n - 1, on, to, from);
            }
        }
    }
    class Move{
        public int poleFrom { get; set; }
        public int poleTo { get; set; }

        public  Move(int from, int to) {
            poleFrom = from;
            poleTo = to;
        }
    }
}
