using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle
{
public interface ISalary
    {
        public double BaseSalary();
        public double NRAllowance();
       
    }
    public interface IVariablepay
    {
        public double Variable();
    }

        public class PermanentEmployee : ISalary, IVariablepay 
    {
        public double BaseSalary()
        {
            return 12000;
        }
        public double NRAllowance()
        {
            return 10000;
        }
        public double Variable()
        {
            return 8000;
        }
    }
    public class ContractEmployee : ISalary
    {
        public double BaseSalary()
        {
            return 7000;
        }
        public double NRAllowance()
        {
            return 5000;
        }
        /*public double Variable()
        {
            return 3000;
        }*/
    }
}
