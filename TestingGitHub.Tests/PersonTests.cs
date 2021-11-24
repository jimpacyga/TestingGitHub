using NUnit.Framework;
using TestingGitHub;

namespace TestingGitHub.Tests
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void PersonCtor_Always_CreatesPerson()
        {
            // Arrange
            int age = 42;
            string hairColor = "brown";
            string name = "bobby";
            int numberOfArms = 2;

            // Act
            Person p = new Person
            {
                HairColor = hairColor,
                Age = age,
                Name = name,
                NumberOfArms = numberOfArms
            };

            // Assert
            Assert.IsNotNull(p);
            Assert.AreEqual(age, p.Age);
            Assert.AreEqual(hairColor, p.HairColor);
            Assert.AreEqual(name, p.Name);
            Assert.AreEqual(numberOfArms, p.NumberOfArms);
        }
    }
}