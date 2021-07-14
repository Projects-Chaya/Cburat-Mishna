using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlPrint
{
    public class BlBase
    {
        DalPrint.DalBase dal=new DalPrint.DalBase("Microsoft Access Database File (OLE DB)", "Mishna.mdb");
        public DataTable GetDataTable(string kod)
        {
            DataTable table;
            return table = dal.fillDataTable(kod);
        }
        public DataTable GetCmb()
        {
            DataTable table;
            return table = dal.fillCmb();
        }
        public DataTable UntilNumber(string kod)
        {
            DataTable table;
            return table = dal.ContinuUntilNumber(kod);
        }
        public int MaxFile(string kod)
        {
            int max;
            return max = dal.CountFiles(kod);
        }
    }
}
