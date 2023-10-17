using System.Reflection.Metadata;

namespace ChallengeApp.Test
{
    public class Tests
    {

        [Test]
        public void SumTestsofEmployees()
        {
            //arrange
            var employee = new Employee("Zdzis³aw", "Walohalo", 45);
            employee.AddScore(7);
            employee.AddScore(-2);
            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(5, result);



        }
    }
}