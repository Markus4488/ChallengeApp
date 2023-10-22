using System.Reflection.Metadata;

namespace ChallengeApp.Test
{
    public class Tests
    {

        [Test]
        public void SumTestsofEmployees()
        {
            //arrange
            var employee = new Employee("Zdzis³aw", "Walohalo");
            employee.Addgrade(7);
            employee.Addgrade(2);
            employee.Addgrade(3);
            //act
            var result = employee.GetStatistics();

            //assert
            Assert.AreEqual(7, result.Max);
            Assert.AreEqual(2, result.Min);
            Assert.AreEqual(4, result.Average);



        }
    }
}