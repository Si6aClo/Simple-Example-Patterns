using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Facade
    {
        SubSystemA SubSystemA = new SubSystemA();
        SubSystemB SubSystemB = new SubSystemB();
        SubSystemC SubSystemC = new SubSystemC();

        public void OperationAB()
        {
            SubSystemA.OperationA();
            SubSystemB.OperationB();
        }

        public void OperationBC()
        {
            SubSystemB.OperationB();
            SubSystemC.OperationC();
        }
    }
}
