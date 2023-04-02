

namespace ChallengeApp_01.Tests
{
    public class EmployeeTest1
    {
        [Test]
        public void WhenUserCollectsTwoScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Bo¿enka", "Ptysiowa", 51);
            employee.AddScore(10);
            employee.AddScore(10);
            employee.AddScore(-21);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(-1, result);
        }
    }
}