using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;
using MiningSystem;

[TestFixture]
public class T02TestHarvestersConstructors
{
    private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;
    
    // Class names
    private Type[] classes =
    {
        GetType("Driller")
    };

    private Type[] ctorParameters = { typeof(string), typeof(double), typeof(double) };

    [Test]
    public void TestMethod()
    {
        foreach (var className in classes)
        {
            AssertConstructors(className);
        }
    }

    private void AssertConstructors(Type className)
    {
        ConstructorInfo[] constructors = className.GetConstructors(BindingFlags.Instance | BindingFlags.Public);

        foreach (var ctor in constructors)
        {
            var parameters = ctor.GetParameters();
            Assert.IsTrue(parameters.Length == ctorParameters.Length);
            for (int i = 0; i < ctorParameters.Length; i++)
            {
                var test = parameters[i].ParameterType;
                Assert.AreEqual(parameters[i].ParameterType, ctorParameters[i], "Constructor parameters are in wrong order");
            }
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