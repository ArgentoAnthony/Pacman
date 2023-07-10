using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pacman.Core
{
    public static class Collision
    {
        public static Color GetColorAt(Vector2 Position)
        {
            Color color = Color.Black;

            /*if ((int)Position.X >= 0 && (int)Position.X < this._world.Width
                && (int)Position.Y >= 0 && (int)Position.Y < this._world.Height)
            {
                color = this.colorTab[(int)Position.X + (int)Position.Y * this._world.Width];
            }
            */
            return color;
        }

        public static bool Collided(Vector2 Position)
        {
            bool b = false;

            /*if (GetColorAt(Position) != _collisionColor)
                b = false;
            else
                b = true;
            */
            return b;
        }
    }
}
