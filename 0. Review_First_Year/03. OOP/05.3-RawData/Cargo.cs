﻿namespace _05._3_RawData
{
    public class Cargo
    {
        public int Weight { get; set; }

        public string Type { get; set; }

        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }
    }
}
