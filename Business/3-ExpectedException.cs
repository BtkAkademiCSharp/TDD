using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ExpectedException
    {
        public void TestRequest(int i)
        {
            if (i == 0)
                throw new ArgumentException("i değeri 0 olamaz");
        }
    }
}
