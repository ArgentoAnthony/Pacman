using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace Pacman.Core
{
    class Player : GameObject
    {   
        public Player(int totalAnimationFrames, int frameWidth, int frameHeight)
            : base(totalAnimationFrames, frameWidth, frameHeight)
        {
            direction = Direction.RIGHT;
            frameIndex = framesIndex.RIGHT_1;
        }

        public void Move(KeyboardState state)
        {
            if (state.IsKeyDown(Keys.Z))
            {
                direction = Direction.TOP;
                Position.Y -= 1;
            }
            if (state.IsKeyDown(Keys.Q))
            {
                direction = Direction.LEFT;
                Position.X -= 1;
            }
            if (state.IsKeyDown(Keys.S))
            {
                direction = Direction.BOTTOM;
                Position.Y += 1;
            }
            if (state.IsKeyDown(Keys.D))
            {
                direction = Direction.RIGHT;
                Position.X += 1;
            }
        }
    }
}
