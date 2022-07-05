using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace SchereSteinPapierEchseSpok
{
    public class Creature
    {
        public string name { get; private set; }
        public List<string> weaknesses { get; private set; }
        public List<string> strenghts { get; private set; }
        public Creature(string pName,string[] pWeaknesses, string [] pStrengths)
        {
            name = pName;

            weaknesses = new List<string>();
            strenghts = new List<string>();

            foreach (string w in pWeaknesses)
            {
                weaknesses.Add(w);
            }
            foreach (string s in pStrengths)
            {
                strenghts.Add(s);
            }


            
        }

        
    }
}
