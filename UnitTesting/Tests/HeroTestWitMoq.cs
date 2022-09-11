using Skeleton;
using Moq;

namespace Tests
{
    public class HeroTestWitMoq
    {
        private const string heroName = "Petar";

        private Mock<ITarget> target;
        private Mock<IWeapon> weapon;
        private Hero hero;

        [SetUp]
        public void Setup()
        {
            target = new Mock<ITarget>();
            target.Setup(t => t.IsDead()).Returns(true);
            target.Setup(t => t.GiveExperience()).Returns(20);

            weapon = new Mock<IWeapon>();

            hero = new Hero(heroName, weapon.Object);
        }

        [Test]
        public void HeroReceivesXPWhenTheTagetDies()
        {
            hero.Attack(target.Object);

            int expectedHeroExperience = target.Object.GiveExperience();
            Assert.AreEqual(expectedHeroExperience, hero.Experience, "Hero doesn't receive experience when the target is dead");
        }
    }
}
