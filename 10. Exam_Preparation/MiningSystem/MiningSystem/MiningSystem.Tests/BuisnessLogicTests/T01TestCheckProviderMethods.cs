using NUnit.Framework;
using System;
using System.Collections.Generic;
using MiningSystem;

[TestFixture]
public class T01TestCheckProviderMethods
{
    private Type sut = typeof(SystemManager);
    private object[] provider = { new List<string>() { "Sun", "Falcon", "100" } };
    private object[] checkCommand = { new List<string>() { "Falcon" } };
    SystemManager manager = new SystemManager();
    private string expectedOutput = "Sun Provider - Falcon\r\nEnergy Output: 125";

    [Test]
    public void TestMethod()
    {
        var register = sut.GetMethod("RegisterProvider");
        var check = sut.GetMethod("Check");

        register.Invoke(manager, provider);
        var checkMessage = check.Invoke(manager, checkCommand);

        Assert.AreEqual(expectedOutput, checkMessage);
    }
}
