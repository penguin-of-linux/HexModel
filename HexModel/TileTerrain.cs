﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexModel
{
    public class TileTerrain
    {
        static readonly Dictionary<string, double> speedOnTerrainType = new Dictionary<string, double>
        {
            {"road", 0.75 },
            {"grass", 1 },
            {"rocky", 1.25 },
            {"snow", 1.5 },
            {"sand", 1.5 },
            {"swamp", 1.75 }
        };

        private string terrainType;
        public string TerrainType
        {
            get { return terrainType; }
            set
            {
                if (!(speedOnTerrainType.ContainsKey(value)))
                    throw new ArgumentException();
                else
                    terrainType = value;
            }
        }
        public double SpeedMult
        {
            get { return speedOnTerrainType[TerrainType]; }
        }

        public TileTerrain(string terrainType)
        {
            TerrainType = terrainType;
        }
    }
}