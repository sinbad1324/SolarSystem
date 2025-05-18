using System;
using SolarSystem.Globals;

namespace SolarSystem.Maths
{
    public abstract class Formule
    {
        public static float Gravity(float mass1 , float mass2 , float distance)
        {
            return GParams.GRAVITY * ((mass1 * mass2) / ((float)Math.Pow(direction, 2)));
        } 
    }
}