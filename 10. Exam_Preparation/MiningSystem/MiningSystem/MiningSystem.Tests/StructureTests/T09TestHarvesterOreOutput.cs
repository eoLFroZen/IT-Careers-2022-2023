using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;
using MiningSystem;

[TestFixture]
public class T09TestHarvesterOreOutput
{
    private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

    private Type sut = GetType("Miner");

    [Test]
    public void TestMethod()
    {
        var propertyInfo = sut.GetProperty("CoalOutput");
        var setMethod = propertyInfo.SetMethod;
        Assert.IsTrue(!setMethod.IsPublic);
    }

    private static Type GetType(string name)
    {
        var type = ProjectAssembly
            .GetTypes()
            .FirstOrDefault(t => t.Name == name);

        return type;
    }
}