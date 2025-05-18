using System.Diagnostics.Contracts;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SolarSystem.Globals
{
    public abstract class GParams
    {
        public const int WINDOW_W = 1000;
        public const int WINDOW_H = 600;
        ContractPublicPropertyNameAttribute
        public static SpriteBatch spriteBatch;
        public static ContentManager content;
        public static GameTime updateTime;
        public static GameTime drawTime;

    }
}