using NUnit.Framework;
using System;
using System.Collections.Generic;
using MiningSystem;

[TestFixture]
public class T14TestShutDown
{
    private Type sut = typeof(SystemManager);
    private object[] harvester = { new List<string>() { "Driller", "AS-51", "20", "50" } };
    private object[] provider = { new List<string>() { "Sun", "Falcon", "100" } };
    SystemManager manager = new SystemManager();
    private string expectedOutput = "System Shutdown\r\nTotal Energy Stored: 125\r\nTotal Mined Coal: 300";

    [Test]
    public void TestMethod()
    {
        var registerHarvester = sut.GetMethod("RegisterMiner");
        var registerProvider = sut.GetMethod("RegisterProvider");
        var day = sut.GetMethod("Day");
        var shutDown = sut.GetMethod("ShutDown");

        registerHarvester.Invoke(manager, harvester);
        registerProvider.Invoke(manager, provider);
        for (int i = 0; i < 5; i++)
        {
            day.Invoke(manager, null);
        }
        var checkMessage = shutDown.Invoke(manager, null);

        Assert.AreEqual(expectedOutput, checkMessage);
    }
}