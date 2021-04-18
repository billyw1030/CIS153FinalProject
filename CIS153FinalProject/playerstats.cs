using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153FinalProject
{

    class Playerstats
    {
        private string playerwins;
        private string aiwins;
        private string tie;
        private string totalplayed;
        private string playerpercent;
        private string aipercent;


        public Playerstats()
        {
            Console.WriteLine("New User Created:");
        }

        //================================= Setters ==================================
        public void SetPlayerwins(string pw)
        {
            playerwins = pw;
        }
        public void SetAiwins(string aw)
        {
            aiwins = aw;
        }
        public void SetTie(string t)
        {
            tie = t;
        }
        public void SetTotalplayed(string tp)
        {
            totalplayed = tp;
        }
        public void SetPlayerpercent(string pp)
        {
            playerpercent = pp;
        }
        public void SetAipercent(string ap)
        {

            aipercent = ap;
        }
        //==================================== End Setters ==============================

        //==================================== Getters ==================================
        public string GetPlayerwins()
        {
            return playerwins;
        }
        public string GetAiwins()
        {
            return aiwins;

        }
        public string GetTie()
        {
            return tie;
        }
        public string GetTotalplayed()
        {
            return totalplayed;
        }
        public string GetPlayerpercent()
        {
            return playerpercent;
        }
        public string GetAipercent()
        {
            return aipercent;
        }
        //===================================== End Getters ====================================





    }
}
