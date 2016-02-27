using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProductCode
{
    public class Class1
    {
        public Service s;

        public Class1()
        {
            s = new Service();
        }

        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, s.Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, s.Add(2, 2));
        }
    }
}
