using Xunit;
using DoorSimulationLib;

namespace DoorSimulationLib.test
{
    public class UnitTestSimpleDoor
    {
        [Fact]
        public void TestOpenDoor()
        {
            // Arrange
            SimpleDoor door = new SimpleDoor("1", "Wood");

            // Act
            door.Open();

            // Assert
            Assert.Equal(DoorState.Open, door.State);
        }

        [Fact]
        public void TestCloseDoor()
        {
            // Arrange
            SimpleDoor door = new SimpleDoor("2", "Metal");

            // Act
            door.Close();

            // Assert
            Assert.Equal(DoorState.Closed, door.State);
        }

        [Fact]
        public void TestInitialStateIsClosed()
        {
            // Arrange
            SimpleDoor door = new SimpleDoor("3", "Glass");

            // Assert
            Assert.Equal(DoorState.Closed, door.State);
        }

        [Fact]
        public void TestOpenAndCloseDoor()
        {
            // Arrange
            SimpleDoor door = new SimpleDoor("4", "Steel");

            // Act
            door.Open();
            door.Close();

            // Assert
            Assert.Equal(DoorState.Closed, door.State);
        }

        [Fact]
        public void TestDoorIdAndMaterial()
        {
            // Arrange
            string doorId = "5";
            string material = "Aluminum";
            SimpleDoor door = new SimpleDoor(doorId, material);

            // Assert
            Assert.Equal(doorId, door.DoorId);
            Assert.Equal(material, door.Material);
        }
    }
}
