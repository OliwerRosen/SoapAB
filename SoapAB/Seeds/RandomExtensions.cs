using System;

namespace SoapAB.Seeds
{
    
    public static class RandomExtensions
    {

        private static Random Random = new Random();

        public static T GetRandom<T>() where T : struct, Enum
        {
            T[]? v = Enum.GetValues<T>();
            return (T)v.GetValue(Random.Next(v.Length));
        }
    }
   
}
