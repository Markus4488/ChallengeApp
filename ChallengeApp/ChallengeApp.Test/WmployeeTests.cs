using System.Reflection.Metadata;

namespace ChallengeApp.Test
{
    public class Tests
    {

        [Test]
        public void Sum_Test_Employees()
        {
            //arrange
            var employee = new Employee("Zdzis�aw", "Walohalo");
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
        [Test]
        public void ABCD_test_Employees()
        {
            //arrange
            var employee = new Employee("Zdzis�aw", "Walohalo");
            employee.Addgrade("A");
            employee.Addgrade('B');
            employee.Addgrade("C");
            employee.Addgrade('D');
            employee.Addgrade("234");

            //act
            var result = employee.GetStatistics();

            //assert
            Assert.AreEqual(100, result.Max);
            Assert.AreEqual(40, result.Min);
            Assert.AreEqual(70, result.Average);



        }

    }
}