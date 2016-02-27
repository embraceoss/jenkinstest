using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleProject;
using Xunit;

namespace TestSampleProject
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Product.Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(4, Product.Add(2, 1));
        }
    }
}
