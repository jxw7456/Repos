using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//JaJuan Webster
//PE22 Dynamic Tree Creation
//Professor Maier

namespace PE22_Dynamic_Tree_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            Random rng = new Random();

            //Insert Numbers
            tree.Insert(rng.Next(100));
            tree.Insert(rng.Next(100));
            tree.Insert(rng.Next(100));
            tree.Insert(rng.Next(100));
            tree.Insert(rng.Next(100));
            tree.Insert(rng.Next(100));
            tree.Insert(rng.Next(100));
            tree.Insert(rng.Next(100));
            tree.Insert(rng.Next(100));
            tree.Insert(rng.Next(100));
            tree.Insert(rng.Next(100));
            tree.Insert(rng.Next(100));
            tree.Insert(rng.Next(100));
            tree.Insert(rng.Next(100));
            tree.Insert(rng.Next(100));

            //Print Tree
            tree.Print();

            //DEBUG
            Console.ReadLine();
        }
    }
}
