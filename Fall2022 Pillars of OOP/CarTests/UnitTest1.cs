using Fall2022_Pillars_of_OOP;
using NuGet.Frameworks;

namespace CarTests
{
    public class Tests
    {


        //Three A's of TDD
        //1.) Arrange - arrange our data, what objects/variables are we using? let's get thme set up before contiuning
        //2.) Act - what are we going to do with that data? what methods are going to run?
        //3.) Assert - what do we expect to see? 
        
        public Car testCar;
        
        [SetUp]
        public void Setup()
        {
           testCar = new Car();
        }

        [Test]
        public void Constructor_Should_Return_Initial_Value_Of_False_For_IsRunning()
        {
            //Arrange - This is being taken car of by our setup method on line 17

            //Act - Also being taken care of with setup Method on line 17

            //Assert
            Assert.AreEqual(false, testCar.IsRunning);
        }
        [Test]//-Helpers
        public void Accelerate_should_Increase_Speed_By_5()
        {
            //Arrange - taken care of in setup method, object car is made in the setup method

            //Act 
            testCar.Accelerate();
            //Assert
            Assert.AreEqual(5, testCar.Speed);

        }
    }
}