using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module1pr31s3
{
    internal class Programmer
    {
        public string surname;
        public int countProg;
        public int countLangProg;

        public Programmer(string _surname, int _countProg, int _countLangProg)
        {
            surname = _surname;
            countProg = _countProg;
            countLangProg = _countLangProg;
        }
        public string _surname { get; set; }
        public int _countProg { get; set; }
        public int _countLangProg { get; set; }

        public int Q()
        {
            int q = countProg * countLangProg;
            return q;
        }
    }
}
