
using System.Collections.Generic;

namespace P04.Recharge
{
    public class RechargeStation: Robot
    {

        private readonly List<Robot> robots;
        public RechargeStation(string id, int capacity) : base(id, capacity)
        {
            robots = new List<Robot>();
        }

        public IReadOnlyCollection<Robot> Robots => robots;
    }
}
