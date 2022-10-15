using NUnit.Framework;
using System;
using System.Collections.Generic;
using MiningSystem;

[TestFixture]
public class T12TestDayModeEnergy
{
    private Type sut = typeof(SystemManager);
    private object[] harvester = { new List<string>() { "Hewer", "AS-51", "20", "50", "10" } };
    private object[] provider = { new List<string>() { "Sun", "Falcon", "200" } };
    SystemManager manager = new SystemManager();
    private string expectedOutput = "A day has passed.\r\nEnergy Provided: 250\r\nMined Coal: 20";

    [Test]
    public void TestMethod()
    {
        var registerHarvester = sut.GetMethod("RegisterMiner");
        var registerProvider = sut.GetMethod("RegisterProvider");
        var check = sut.GetMethod("Day");

        registerHarvester.Invoke(manager, harvester);
        registerProvider.Invoke(manager, provider);
        var checkMessage = check.Invoke(manager, null);

        Assert.AreEqual(expectedOutput, checkMessage);
    }
}