using Skeleton;

namespace Tests
{
    public class FakeTarget : ITarget
    {
        public int Health => 20;

        public int GiveExperience()
        {
            return 20;
        }

        public bool IsDead()
        {
            return true;
        }

        public void TakeAttack(int attackPoints)
        {
        }
    }
}
