using Xunit;
using Contacts_Manager;
using System.Collections.Generic; // For working with lists

namespace ContactManagerTests;

public class UnitTest1
{
    [Fact]
  public void AddContact()
{
    // Arrange (Set up the initial state)
    string newContact = "Salam";

    // Act (Call the method you want to test)
    Program.AddContact(newContact); 

    // Assert (Verify the expected outcome)
    Assert.Contains("Salam", newContact);

}
    [Fact]
  public void RemoveContact()
{
    // Arrange (Set up the initial state)
    string newContact2 = "Salam";

    // Act (Call the method you want to test)
    Program.RemoveContact(newContact2); 

    // Assert (Verify the expected outcome)
    Assert.Contains("Salam", newContact2);

}
    [Fact]
  public void ViewAllContactss()
{
    // Arrange (Set up the initial state)
    string newContact3 = "Salam";
    string newContact53 = "Ahmad";

    // Act (Call the method you want to test)
    Program.AddContact(newContact3); 
    Program.AddContact(newContact53); 
    Program.ViewAllContacts(); 

    // Assert (Verify the expected outcome)
    Assert.Contains("Salam", newContact3);

}
    [Fact]
  public void AddContacts()
{
    // Arrange (Set up the initial state)
    string newContact4 = "Salam";
    string newContact5 = "Salam";

    // Act (Call the method you want to test)
    Program.AddContact(newContact5); 

    // Assert (Verify the expected outcome)
    Assert.Contains("Salam", newContact5);

}
}