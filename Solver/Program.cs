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
            for(int i = 0; i < tList.Count; i++){
                Console.Write(tList[i]);
            }
            try {
                List<List<int>> toPrint = ListPermutations(tList);
                foreach(List<int> perm in toPrint){
                    for(int i = 0; i < perm.Count; i++){
                        Console.Write(perm[i]);
                    }        
                    Console.WriteLine();
                }
            } catch {
                Console.Write("I Goofed");
            }
            
        }

        //TODO Checker

        //TODO Permutator
        private static List<List<int>> ListPermutations(List<int> values){
            List<List<int>> permList = new List<List<int>>();
            List<int> l = new List<int>(values);
            int s = l.Count;
            if (s <= 1){
                permList.Add(l);
                return permList;
            }

            for (int i = 0; i < s; i++){
                int x = l[i];
                l.RemoveAt(i);

                //Console.Write(l);
                //for(int j = 0; j < l.Count; j++){
                //    Console.Write(l[j]);
                //}

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
