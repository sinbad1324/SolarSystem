
using System;
using Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SolarSystem.Globals;

namespace SolarSystem.Module.Astre
{
    public class Planet
    {
        public Vector2 size { get { return _size; } set { _size = value; rectangle.Size = value.ToPoint(); } }

        public Vector2 position;
        public float mass;
        private Texture2D texture;
        private Rectangle rectangle;
        private Vector2 _size;
        /*;
        ;
        
        */
        public Planet(Vector2 size, Vector2 basePosition, float mass)
        {
            this.size = size;
            position = basePosition;
            this.mass = mass;
        }

        public void Initialize()
        {
            rectangle = new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
        } // #2
        public void LoadContent(string texture)
        {
            this.texture = GParams.content.Load<Texture2D>(texture);
        } // #1
        public void Update()
        {
            rectangle.Location = position.ToPoint();

        } // #3
        public void Draw()
        {
            GParams.spriteBatch.Begin();
            GParams.spriteBatch.Draw(texture, rectangle, Color.White);
            GParams.spriteBatch.End();
        } // #4
        /// <summary>
        /// Clcule la distance entre lui un un autre planet
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public float GetDistance(Planet p)
        {
            return Math.Abs((position - p.position).Length());
        }
        /// <summary>
        /// Clcule la distance entre lui un un autre vector2
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public float GetDistance(Vector2 p)
        {
            return Math.Abs((position - p).Length());
        }
    }
}