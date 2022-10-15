using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;
using MiningSystem;

[TestFixture]
public class T06TestProviderHierarchy
{
    private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

    // Class names
    private Type[] classes =
    {
        GetType("SunProvider"),
        GetType("ElectricityProvider")
    };

    private Type parentClass = GetType("Provider");

    [Test]
    public void TestMethod()
    {
        foreach (var className in classes)
        {
            Assert.IsTrue(CheckHierarchy(className));
        }
    }

    private bool CheckHierarchy(Type className)
    {
        var baseClass = className.BaseType;
        while (baseClass != typeof(object))
        {
            if (baseClass == parentClass)
            {
                return true;
            }
            baseClass = baseClass.BaseType;
        }
        return false;
    }

    private static Type GetType(string name)
    {
        var type = ProjectAssembly
            .GetTypes()
            .FirstOrDefault(t => t.Name == name);

        return type;
    }
}