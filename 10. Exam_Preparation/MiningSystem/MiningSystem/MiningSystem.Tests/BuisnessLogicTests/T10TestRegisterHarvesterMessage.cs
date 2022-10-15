using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using MiningSystem;

[TestFixture]
public class T10TestRegisterHarvesterMessage
{
    private Type sut = typeof(SystemManager);
    private object[] harvester = { new List<string>() { "Hewer", "AS-51", "20", "50", "10" } };
    SystemManager manager = new SystemManager();
    private string expectedOutput = "Successfully registered Hewer Miner - AS-51";

    [Test]
    public void TestMethod()
    {
        var list = new Queue<int>();
        var fieldsBeforeRegister = sut.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
        foreach (var fieldInfo in fieldsBeforeRegister)
        {
            if (fieldInfo.FieldType.IsGenericType)
            {
                var t = fieldInfo.GetValue(manager);
                string testingMethod = "Count";
                int cnt = (int)t.GetType().GetProperty(testingMethod, BindingFlags.Instance | BindingFlags.Public).GetValue(t);
                list.Enqueue(cnt);
            }
        }

        var method = sut.GetMethod("RegisterMiner");
        var message = method.Invoke(manager, harvester);

        var fieldsAfterRegister = sut.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

        Assert.IsTrue(AssertCollectionsCount(list, fieldsAfterRegister));
        Assert.AreEqual(expectedOutput, message);
    }

    private bool AssertCollectionsCount(Queue<int> list, FieldInfo[] fieldsAfterRegister)
    {
        for (int j = 0; j < fieldsAfterRegister.Length; j++)
        {
            if (fieldsAfterRegister[j].FieldType.IsGenericType)
            {
                var t = fieldsAfterRegister[j].GetValue(manager);
                string testingMethod = "Count";
                int cnt = (int)t.GetType().GetProperty(testingMethod, BindingFlags.Instance | BindingFlags.Public).GetValue(t);

                if (cnt != list.Dequeue())
                {
                    return true;
                }
            }
        }
        return false;
    }
}
