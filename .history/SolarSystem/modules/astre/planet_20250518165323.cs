
using Interfaces;
using Microsoft.Xna.Framework;

namespace SolarSystem.Module.Astre
{
    public class Planet : IBasic
    {
        public Vector2 size;
        public Vector2 position;
        public float mass;
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
        public void LoadContent(Textu){} // #1
        public void Update(){} // #3
        public void Draw(){} // #4

    }
}