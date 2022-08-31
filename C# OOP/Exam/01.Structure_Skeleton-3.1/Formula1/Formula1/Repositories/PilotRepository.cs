﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Formula1.Models.Contracts;
using Formula1.Repositories.Contracts;

namespace Formula1.Repositories
{
    public class PilotRepository: IRepository<IPilot>
    {
        private List<IPilot> pilots;

        public PilotRepository()
        {
            pilots = new List<IPilot>();
        }

        public IReadOnlyCollection<IPilot> Models => pilots;
        public void Add(IPilot model)
        {
            pilots.Add(model);
        }

        public bool Remove(IPilot model)
        {
            return pilots.Remove(model);
        }

        public IPilot FindByName(string name)
        {
            return pilots.FirstOrDefault(x => x.FullName == name);
        }
    }
}
