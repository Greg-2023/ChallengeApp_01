namespace ChallengeApp_01.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenIntNotEqualShouldTestPass()
        {
            // arrange
            int numer1 = 1;
            int numer2 = 2;
            
            // act


            // assert
            Assert.AreNotEqual(numer1, numer2);
        }

        public void WhenStringTheSameShouldTestPass()
        {
            // arrange
            var employee1 = GetEmployee("Adam");
            var employee2 = GetEmployee("Adam");

            // act


            // assert
            Assert.AreEqual(employee1.Name, employee2.Name);
        }


        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
