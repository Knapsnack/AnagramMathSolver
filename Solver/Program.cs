using System;
using System.Collections.Generic;
namespace Solver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> tList = new List<int>{0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            List<List<int>> toPrint = ListPermutations(tList);
            foreach(List<int> perm in toPrint){
                Console.Write(perm);
            }
        }

        //TODO Checker

        //TODO Permutator
        private static List<List<int>> ListPermutations(List<int> l){
            List<List<int>> permList = new List<List<int>>();
            int s = l.Count;
            if (s <= 1){
                permList.Add(l);
                return permList;
            }

            for (int i = 0; i < s; i++){
                int x = l[i];
                l.RemoveAt(i);
                List<List<int>> temp = ListPermutations(l); 
                foreach (List<int> y in temp){
                    y.Insert(0, x);
                    permList.Add(y);
                }
                l.Insert(i, x);
            }
            return permList;
        }


        //TODO Initializer

        
    }
}
