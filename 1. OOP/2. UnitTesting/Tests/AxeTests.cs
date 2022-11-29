namespace Tests
{
    public class AxeTests
    {
        private const int axeIniatialAttack = 10;
        private const int axeIniatialDurability = 5;
        private const int dummyIniatialHealth = 100;
        private const int dummyIniatialExperiance = 10;

        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void Setup()
        {
            axe = new Axe(axeIniatialAttack, axeIniatialDurability);
            dummy = new Dummy(dummyIniatialHealth, dummyIniatialExperiance);
        }

        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            axe.Attack(dummy);

            Assert.AreEqual(axeIniatialDurability - 1, axe.DurabilityPoints, 
                "Axe doesn't lose durability after attack");
        }

        [Test]
        public void AxeCantAttackIfBroken()
        {
            for (int i = 0; i < axeIniatialDurability; i++)
            {
                axe.Attack(dummy);
            }
            
            var exception = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));

            const string expectedExceptionMessage = "Axe is broken.";
            Assert.AreEqual(expectedExceptionMessage, exception.Message, 
                "Axe throws exception with the wrong message when trying to attack broken");
        }
    }
}