using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDo;

namespace ToDo.Tests
{
  [TestClass]
  public class ToDoTest
  {
    [TestMethod]
    public void funct___()
    {
      // Arrange
      string testSample = "Clean my room.";
      Item newItem = new Item(testSample);

      // Act
      string result = newItem.GetListItem();
      // Assert
      Assert.AreEqual(testSample, result);
    }
  }
}
