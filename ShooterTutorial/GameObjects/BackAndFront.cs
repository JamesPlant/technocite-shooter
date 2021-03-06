﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ShooterTutorial.GameObjects
{
    class BackAndFront : Weapon
    {

        public BackAndFront(Game1 game, Player player) : base(game, player)
        {
        }

        public override void Fire(GameTime gameTime)
        {
            // govern the rate of fire for our lasers
            if (gameTime.TotalGameTime - _previousLaserSpawnTime > _laserSpawnTime)
            {
                _previousLaserSpawnTime = gameTime.TotalGameTime;

                // Add the laer to our list.
                _game.AddLaser(LinearMovement.create(_player.Position, -10f, 0.0f));
                _game.AddLaser(LinearMovement.create(_player.Position, -10f, 180.0f));


            }

        }
    }
}
