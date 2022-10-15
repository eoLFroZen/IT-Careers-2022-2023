using NUnit.Framework;
using System;
using System.Collections.Generic;
using MiningSystem;

[TestFixture]
public class T13TestDayModeFull
{
    private Type sut = typeof(SystemManager);
    private object[] harvester = { new List<string>() { "Hewer", "AS-51", "20", "50", "10" } };
    private object[] provider = { new List<string>() { "Sun", "Falcon", "5" } };
    SystemManager manager = new SystemManager();
    private string expectedDayMessage = "A day has passed.\r\nEnergy Provided: 6.25\r\nMined Coal: 20";
    private string expectedShutDownMessage = "System Shutdown\r\nTotal Energy Stored: 1.25\r\nTotal Mined Coal: 20";

    [Test]
    public void TestMethod()
    {
        var registerHarvester = sut.GetMethod("RegisterMiner");
        var registerProvider = sut.GetMethod("RegisterProvider");
        var day = sut.GetMethod("Day");
        var shutDown = sut.GetMethod("ShutDown");

        registerHarvester.Invoke(manager, harvester);
        registerProvider.Invoke(manager, provider);
        var dayMessage = day.Invoke(manager, null);
        var shutDownMessage = shutDown.Invoke(manager, null);

        Assert.AreEqual(expectedDayMessage, dayMessage);
        Assert.AreEqual(expectedShutDownMessage, shutDownMessage);
    }
}