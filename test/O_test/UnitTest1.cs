using System;
using Xunit;
using nightAtMuseum;
using System.Collections.Generic;


namespace O_test
{
    public class UnitTest1
    {
        [Fact]
        public void ArtworkNotNull()
        {
            // Arrange
           Artwork art = new Artwork("", "", "");
           // Act
           var resulat = new Artwork("", "", "");
           // Assert
           Assert.NotNull(resulat);
        }
        
        [Fact]
        public void RoomNotNull()
        {   //Arrange
            Room room = new Room("");
            //Act
            var result = new Room("");
            //Assert
            Assert.NotNull(result);
        }
        
        [Fact]
        public void GreenRoomNotNull()
        {   
           

             //Arrange
             Room room = new Room("Green rooom");
            // Act
            var resulat = new Room("Green room");
            // Assert
            Assert.NotNull(resulat);
        }

            


    }
}
