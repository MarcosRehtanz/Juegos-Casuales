using System;

namespace Statistics.Models
{
    [Serializable]
    public class StatisticsModel
    {
        public float Healt { get; set; }
        public float? Damage { get; set; }
        public float? SpeedAttack { get; set; }
        public int? Speed { get; set; }
        public int? Range { get; set; }
        public float? Armor { get; set; }
    }


}