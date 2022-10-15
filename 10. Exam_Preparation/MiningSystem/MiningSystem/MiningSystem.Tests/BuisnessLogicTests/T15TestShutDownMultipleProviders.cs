using NUnit.Framework;
using System;
using System.Collections.Generic;
using MiningSystem;

[TestFixture]
public class T15TestShutDownMultipleProviders
{
    private Type sut = typeof(SystemManager);
    private object[] harvester = { new List<string>() { "Hewer", "AS-51", "20", "50", "10" } };
    private object[] provider = { new List<string>() { "Sun", "Falcon", "100" } };
    private object[] provider2 = { new List<string>() { "Electricity", "Falcon2", "100" } };
    SystemManager manager = new SystemManager();
    private string expectedOutput = "System Shutdown\r\nTotal Energy Stored: 1620\r\nTotal Mined Coal: 120";

    [Test]
    public void TestMethod()
    {
        var registerHarvester = sut.GetMethod("RegisterMiner");
        var registerProvider = sut.GetMethod("RegisterProvider");
        var day = sut.GetMethod("Day");
        var shutDown = sut.GetMethod("ShutDown");

        registerHarvester.Invoke(manager, harvester);
        registerProvider.Invoke(manager, provider);
        registerProvider.Invoke(manager, provider2);
        day.Invoke(manager, null);
        day.Invoke(manager, null);
        day.Invoke(manager, null);
        day.Invoke(manager, null);
        day.Invoke(manager, null);
        day.Invoke(manager, null);
        var checkMessage = shutDown.Invoke(manager, null);

        Assert.AreEqual(expectedOutput, checkMessage);
    }
}