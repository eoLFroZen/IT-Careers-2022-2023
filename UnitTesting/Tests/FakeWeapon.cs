using Skeleton;

namespace Tests
{
    public class FakeWeapon : IWeapon
    {
        public int AttackPoints => 20;

        public int DurabilityPoints => 10;

        public void Attack(ITarget target)
        {
        }
    }
}
