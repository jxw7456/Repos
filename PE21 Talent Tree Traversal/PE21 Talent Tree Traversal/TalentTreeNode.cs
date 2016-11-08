using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE21_Talent_Tree_Traversal
{
    class TalentTreeNode
    {
        //Attributes
        private string abilityName;
        Boolean hasLearned;
        private TalentTreeNode left;
        private TalentTreeNode right;

        //Construtor
        public TalentTreeNode(string name, bool learned)
        {
            abilityName = name;
            hasLearned = learned;
            left = null;
            right = null;
        }

        //Properties
        public TalentTreeNode Left
        {
            get { return left; }
            set { left = value; }
        }

        public TalentTreeNode Right
        {
            get { return right; }
            set { right = value; }
        }

        //Recursion
        public void ListKnownAbilities(TalentTreeNode current)
        {
            if (current != null)
            {
                if (current.hasLearned == true)
                {
                    ListKnownAbilities(current.Left);
                    Console.WriteLine(current.abilityName);
                    ListKnownAbilities(current.Right);
                }
            }
        }

        public void ListPossibleAbilities(TalentTreeNode current)
        {
            if (current != null)
            {
                ListPossibleAbilities(current.Left);
                if (current.hasLearned == false)
                {

                    Console.WriteLine(current.abilityName);

                }
                ListPossibleAbilities(current.Right);
            }
        }
    }
}
