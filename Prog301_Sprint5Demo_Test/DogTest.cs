using Prog301_Sprint5Demo.Models;

namespace Prog301_Sprint5Demo_Test
{
    [TestClass]
    public class DogTest
    {



        [TestMethod]
        public void DogConstructorDefault()
        {
            // Arrange
            Dog dog = new Dog();
            string defaultName = "fido";
            int defaultAge = 1;
            int defaultWeight = 1;
            string defaultBarkSound = "woof!";
            // Act

            // Assert
            Assert.AreEqual(defaultName, dog.Name);
            Assert.AreEqual(defaultAge, dog.Age);
            Assert.AreEqual(defaultWeight, dog.Weight);
            Assert.AreEqual(defaultBarkSound, dog.BarkSound);
        }
        [TestMethod]
        public void DogBark()
        {
            // Arrange
            Dog dog = new Dog();
            string expectedBark;

            // Act
            expectedBark = "woof!";

            // Assert
            Assert.AreEqual(expectedBark, dog.Bark());
        }
        [TestMethod]
        public void DogAbout()
        {
            // Arrange
            Dog dog = new Dog();
            string expectedString = "";

            // Act
            expectedString = $"Hello, my name is fido";

            //Assert
            Assert.AreEqual(expectedString, dog.About());
        }
        [TestMethod]
        public void DogInherited()
        {
            // Arrange
            Dog dog = new Dog();

            // Act

            //Assert
            Assert.IsInstanceOfType(dog,typeof(IEatable));
            Assert.IsInstanceOfType(dog,typeof(IIAboutable));
            Assert.IsInstanceOfType(dog,typeof(IBarkable));
        }
    }
}