using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace MicroFeel.Finance.XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            TestA a = TestA.name;
            TestA b = TestA.name1;
            var astring = a.ToAttrString();
            var bstring = b.ToAttrString();
            Console.WriteLine(astring);
            Console.WriteLine(bstring);
            Assert.True(astring == "/api/controller");

        }

        [Fact]
        public void TestCaller()
        {
            var s = Caller();
            Assert.Equal(s, "TestCaller");
        }

        [Fact]
        public void TestCaller1()
        {
            var s = Caller1();
            Assert.Equal(s, "Caller1");
        }

        [Fact]
        public async Task TestTaskAsync()
        {
            var t = Task<string>.Run(() => { 
                Thread.Sleep(10000);
                return "10"; });
           // var s = await t;
            Console.WriteLine("1");
            Assert.Equal("","10");
        }

        private string Caller1()
        {
            return Caller();
        }

        private string Caller([CallerMemberName]string caller = "")
        {
            return caller;
        }

    }

    public enum TestA
    {
        [FinancialPath("/api/controller")]
        name,
        [FinancialAction("add")]
        name1
    }
}
