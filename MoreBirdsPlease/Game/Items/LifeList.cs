﻿using System;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using DynamicGameAssets.Game;
using DynamicGameAssets.PackData;
using StardewValley.BellsAndWhistles;
using StardewValley.Monsters;
using System.Collections.Generic;
using MailFrameworkMod;
using SpaceShared;
using System.Linq;

namespace MoreBirdsPlease.Game.Items
{
    [XmlType("Mods_Ivy_MoreBirdsPlease_LifeList")]
    public class LifeList : CustomObject
    {
        public LifeList() : base((ObjectPackData)ModEntry.dgaPack.Find("LifeList"))
        { 
        }

        public override bool performUseAction(GameLocation location)
        {
            if (DataManager.SaveData.lifeList.Length > 0)
            {
                var lifeListNames = DataManager.SaveData.lifeList
                    .Select(birdieId => DataManager.Birdies.First(birdie => birdie.id.Equals(birdieId)))
                    .Select(birdie => birdie.name);

                Game1.drawObjectDialogue($"{Game1.player.Name}'s life list ({lifeListNames.Count()}/{DataManager.Birdies.Count()}): {String.Join(", ", lifeListNames)}");
            } else
            {
                Game1.drawObjectDialogue($"{Game1.player.Name}'s life list: empty. Tip: binoculars can help you identify the birds around you!");
            }

            return false;
        }
    }
}
