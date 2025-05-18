
using Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SolarSystem.Module.Astre
{
    public class Planet : IBasic
    {
        public Vector2 size;
        public Vector2 position;
        public float mass;
        private Texture2D texture;
        /*;
        ;
        
        */
        public Planet(Vector2 size, Vector2 basePosition, float mass)
        {
            this.size = size;
            position = basePosition;
            this.mass = mass;
        }

        public void Initialize(){} // #2
        public void LoadContent(Texture2D texture)
        {
            this.texture = text
        } // #1
        public void Update(){} // #3
        public void Draw(){} // #4

    }
}