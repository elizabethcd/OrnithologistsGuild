﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace MoreBirdsPlease.Models
{
    public class FeederModel
    {
        public string id;
        public string type;

        public int perchOffset;

        public int range;
        public int maxFlocks;
    }

    public class FoodModel
    {
        public string id;
        public int feederAssetIndex;
    }

    public class BirdieModel
    {
        public string id;
        public string name;
        // TODO asset
        public int maxFlockSize;
        public int weightedBath;
        public Dictionary<string, int> weightedFoods;
        public Dictionary<string, int> weightedFeeders;
    }
}

