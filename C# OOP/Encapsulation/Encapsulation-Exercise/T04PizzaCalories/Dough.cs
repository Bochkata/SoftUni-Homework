

using System;
using System.Collections.Generic;


namespace Restaurant
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;
        private const int BASECALORIESPERGRAM = 2;
       public Dough(string flourType, string bakingTechnique, double weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        private Dictionary<string, double> flour_Modifiers = new Dictionary<string, double>()
        {
            {"white", 1.5},
            {"wholegrain", 1.0},
            {"crispy", 0.9},
            {"chewy", 1.1},
            {"homemade", 1.0}
        };
    public string FlourType
        {
            get { return flourType; }
            private set
            {
                if (!flour_Modifiers.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value;
            }
        }
       

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set
            {
                if (!flour_Modifiers.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                bakingTechnique = value;
            }
        }
        

        public double Weight
        {
            get { return weight; }
            private set
            {
                if (value < 0 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        public double Calories => BASECALORIESPERGRAM * Weight * flour_Modifiers[flourType.ToLower()] * flour_Modifiers[bakingTechnique.ToLower()];
      
    }
}
