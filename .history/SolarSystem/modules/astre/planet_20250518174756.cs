
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
        public string name;
        public Vector2 position;
        public Vector2 stringPos;
        public float mass;
        private Texture2D texture;
        private Rectangle rectangle;
        private Vector2 _size;
        private SpriteFont font;

        private void ShowInfo()
        {
            int add = 40;
            GParams.spriteBatch.DrawString(font, "Position: " + position, stringPos + new Vector2(0, add), Color.White);
            GParams.spriteBatch.DrawString(font, "Mass : " + mass, stringPos + new Vector2(0, add * 2), Color.White);
            GParams.spriteBatch.DrawString(font, "Distance : " + GetDistance(Vector2.Zero), stringPos + new Vector2(0, add * 3), Color.White);
            GParams.spriteBatch.DrawString(font, "Direction : " + GetDirection(Vector2.Zero), stringPos + new Vector2(0, add * 4), Color.White);
        }
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
            font = GParams.content.Load<SpriteFont>("arial");
        } // #1
        public void Update()
        {
            rectangle.Location = position.ToPoint();

        } // #3
        public void Draw()
        {
            GParams.spriteBatch.Begin();
            GParams.spriteBatch.Draw(texture, rectangle, Color.White);
            ShowInfo();
            GParams.spriteBatch.End();
        } // #4
        /// <summary>
        /// Clcule la distance entre lui un un autre planet
        /// </summary>
        /// <param name="p"></param>
        /// <returns>distance float</returns>
        public float GetDistance(Planet p)
        {
            return (p.position - position).Length();
        }
        /// <summary>
        /// Clcule la distance entre lui un un autre vector2
        /// </summary>
        /// <param name="p"></param>
        /// <returns>distance float</returns>
        public float GetDistance(Vector2 p)
        {
            return (p - position).Length();
        }
        /// <summary>
        /// Calcul la direction vers une Vector2
        /// </summary>
        /// <param name="p"></param>
        /// <returns>direction Vector2float</returns>
        public Vector2 GetDirection(Vector2 p)
        {
            Vector2 dif = p - position;
            dif.Normalize();
            return dif;
        }
        /// <summary>
        /// Calcul la direction vers une planet
        /// </summary>
        /// <param name="p"></param>
        /// <returns>direction Vector2float</returns>
        public Vector2 GetDirection(Planet p)
        {
            Vector2 dif = p.position - position;
            dif.Normalize();
            return dif;
        }
    }
}