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
        float Healt();
        float Damage();
        float SpeedAttack { get; }
        float Speed();
        float Range();
        float Armor();
    }
    [Serializable]
    public class StatisticsModel : IStats
    {
        private readonly StatsBasic _stats;
        public StatisticsModel(StatsBasic stats)
        {
            _stats = stats;
        }
        public float Healt()
        {
            return _stats.Healt;
        }
        public float Damage()
        {
            return _stats.Damage;
        }
        public float SpeedAttack { get => GetSpeedAttack(); }
        private float GetSpeedAttack()
        {
            return _stats.SpeedAttack;
        }
        public float Speed()
        {
            return _stats.Speed;
        }
        public float Range()
        {
            return _stats.Range;
        }
        public float Armor()
        {
            return _stats.Armor;
        }
    }


}