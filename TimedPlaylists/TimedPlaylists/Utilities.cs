using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimedPlaylists
{
    public static class Utilities
    {
        /// <summary>
        /// Returns a random element from this collection.
        /// </summary>
        public static T GetRandom<T>(this List<T> source)
        {
            // Create a new random to ensure that it's more random
            var rand = new Random();
            return source[rand.Next(source.Count)];
        }
    }
}
