using NUnit.Framework;
using System;
using System.Collections.Generic;
using MiningSystem;

[TestFixture]
public class T02TestCheckHarvesterMethods
{
    private Type sut = typeof(SystemManager);
    private object[] harvester = { new List<string>() { "Hewer", "AS-51", "20", "50", "10" } };
    private object[] checkCommand = { new List<string>() { "AS-51" } };
    SystemManager manager = new SystemManager();
    private string expectedOutput = "Hewer Miner - AS-51\r\nCoal Output: 20\r\nEnergy Requirement: 5";

    [Test]
    public void TestMethod()
    {
        var register = sut.GetMethod("RegisterMiner");
        var check = sut.GetMethod("Check");

        register.Invoke(manager, harvester);
        var checkMessage = check.Invoke(manager, checkCommand);

        Assert.AreEqual(expectedOutput, checkMessage);
    }
}
