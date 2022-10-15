using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;
using MiningSystem;

[TestFixture]
public class T05TestAbstractClasses
{
    private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

    // Class names
    private Type[] classes =
    {
        GetType("Miner"),
        GetType("Driller"),
        GetType("Hewer"),
        GetType("Provider"),
        GetType("SunProvider"),
        GetType("ElectricityProvider")
    };

    [Test]
    public void TestMethod()
    {
        foreach (var className in classes)
        {
            AssertFields(className);
        }
    }

    private void AssertFields(Type className)
    {
        var fields = className.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        foreach (var fieldInfo in fields)
        {
            Assert.IsTrue(fieldInfo.IsPrivate, $"{fieldInfo.Name} in {className.Name} is NOT Private");
        }
    }

    private static Type GetType(string name)
    {
        var type = ProjectAssembly
            .GetTypes()
            .FirstOrDefault(t => t.Name == name);

        return type;
    }
}