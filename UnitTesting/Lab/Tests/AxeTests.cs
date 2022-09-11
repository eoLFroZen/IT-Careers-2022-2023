namespace Tests
{
    public class AxeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(9, axe.DurabilityPoints, "Axe doesn't lose durability after attack");
        }

        [Test]
        public void AxeCantAttackIfBroken()
        {
            Axe axe = new Axe(10, 1);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            var exception = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.AreEqual("Axe is broken.", exception.Message, "Axe throws exception with the wrong message when trying to attack broken");
        }
    }
}