using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module1pr31s3
{
    internal class WorkTrue : Programmer
    {
        public int workProgTrue;

        public WorkTrue(string _surname, int _countProg, int _countLangProg, int _workProgTrue) : base(_surname, _countProg, _countLangProg)
        {
            workProgTrue = _workProgTrue;
        }
        public int _workProgTrue { get; set; }

        public void Qp(int q)
        {
            int qp = workProgTrue * q / countProg;
            Console.WriteLine("Qp = " + qp);
        }
    }
}
