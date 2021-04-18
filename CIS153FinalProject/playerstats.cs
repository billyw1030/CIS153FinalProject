using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153FinalProject
{

    class playerstats
    {
        private string playerwins;
        private string aiwins;
        private string tie;
        private string totalplayed;
        private string playerpercent;
        private string aipercent;


        public playerstats()
        {
            Console.WriteLine("New User Created:");
        }

        //================================= Setters ==================================
        public void setPlayerwins(string pw)
        {
            playerwins = pw;
        }
        public void setAiwins(string aw)
        {
            aiwins = aw;
        }
        public void setTie(string t)
        {
            tie = t;
        }
        public void setTotalplayed(string tp)
        {
            totalplayed = tp;
        }
        public void setPlayerpercent(string pp)
        {
            playerpercent = pp;
        }
        public void setAipercent(string ap)
        {

            aipercent = ap;
        }
        //==================================== End Setters ==============================

        //==================================== Getters ==================================
        public string getPlayerwins()
        {
            return playerwins;
        }
        public string getAiwins()
        {
            return aiwins;

        }
        public string getTie()
        {
            return tie;
        }
        public string getTotalplayed()
        {
            return totalplayed;
        }
        public string getPlayerpercent()
        {
            return playerpercent;
        }
        public string getAipercent()
        {
            return aipercent;
        }
        //===================================== End Getters ====================================





    }
}
