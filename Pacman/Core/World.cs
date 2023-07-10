using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework; // A rajouter dans le tutoriel

namespace Pacman.Core
{
    class World : GameObject
    {
        // A rajouter dans le tutoriel
        private Color _collisionColor;
        public Color collisionColor
        {
            get { return _collisionColor; }
        }

        public World(Color collisionColor)
        {
            _collisionColor = collisionColor;
        }
    }
}
