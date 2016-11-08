using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//JaJuan Webster
//PE21 Talent Tree
//Professor Maier

namespace PE21_Talent_Tree_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nodes: Star Wars
            TalentTreeNode push = new TalentTreeNode("Force Push", true);
            TalentTreeNode saberThrow = new TalentTreeNode("Force Saber Throw", true);
            TalentTreeNode lightning = new TalentTreeNode("Force Lightning", true);
            TalentTreeNode shield = new TalentTreeNode("Force Lightning Shield", false);
            TalentTreeNode slash = new TalentTreeNode("Sith Slash", false);
            TalentTreeNode repulse = new TalentTreeNode("Force Repulse", false);
            TalentTreeNode sling = new TalentTreeNode("Sith Sling", false);

            //Node Relationships
            push.Left = saberThrow;
            push.Right = lightning;
            saberThrow.Left = shield;
            saberThrow.Right = slash;
            lightning.Left = repulse;
            lightning.Right = sling;

            //Known Abilities
            Console.WriteLine("Known Abilities: ");
            push.ListKnownAbilities(push);

            //INDENT
            Console.WriteLine();

            //Possible Abilities
            Console.WriteLine("Possible Abilities: ");
            push.ListPossibleAbilities(push);

            //DEBUG
            Console.ReadLine();
        }
    }
}
