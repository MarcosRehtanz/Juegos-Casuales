using System;

namespace Statistics.Models
{
    [Serializable]
    public class StatsBasic
    {
        public float Healt = 0;
        public float Damage = 0;
        public float SpeedAttack = 0;
        public float Speed = 0;
        public float Range = 0;
        public float Armor = 0;
    }
    public interface IStats
    {
        float GetHealt();
        float GetDamage();
        float GetSpeedAttack();
        float GetSpeed();
        float GetRange();
        float GetArmor();
    }
    [Serializable]
    public class StatisticsModel : IStats
    {
        private readonly StatsBasic _stats;
        public StatisticsModel( StatsBasic stats)
        {
            _stats = stats;
        }
        public float GetHealt()
        {
            return _stats.Healt;
        }
        public float GetDamage()
        {
            return _stats.Damage;
        }
        public float GetSpeedAttack()
        {
            return _stats.SpeedAttack;
        }
        public float GetSpeed()
        {
            return _stats.Speed;
        }
        public float GetRange()
        {
            return _stats.Range;
        }
        public float GetArmor()
        {
            return _stats.Armor;
        }
    }


}