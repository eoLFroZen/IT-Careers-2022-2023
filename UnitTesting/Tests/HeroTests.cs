using Skeleton;

namespace Tests
{
    public class HeroTests
    {
        private IWeapon weapon;
        private ITarget target;

        [SetUp]
        public void Setup()
        {
            weapon = new FakeWeapon();
            target = new FakeTarget();
        }

        [Test]
        public void HeroReceivesXPWhenTheTagetDies()
        {
            Hero hero = new Hero("Hero1", weapon);

            hero.Attack(target);

            Assert.AreEqual(20, hero.Experience, "Hero doesn't receive experience when the target is dead");
        }
    }
}
