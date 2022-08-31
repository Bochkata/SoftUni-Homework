﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Formula1.Models.Contracts;
using Formula1.Repositories.Contracts;

namespace Formula1.Repositories
{
   public class RaceRepository: IRepository<IRace>
   {
       private List<IRace> races;

       public RaceRepository()
       {
           races = new List<IRace>();
       }
       public IReadOnlyCollection<IRace> Models => races;
        public void Add(IRace model)
        {
            races.Add(model);
        }

        public bool Remove(IRace model)
        {
            return races.Remove(model);
        }

        public IRace FindByName(string name)
        {
            return races.FirstOrDefault(x => x.RaceName == name);
        }
    }
}
