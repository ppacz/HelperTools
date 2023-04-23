using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Unknown.HelperTools.Extentions
{
    public static class ListExtention
    {
        /// <summary>
        /// Returns random element from list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static T Random<T>(this IList<T> list)
        {
            return list[UnityEngine.Random.Range(0, list.Count)];
        }    

        /// <summary>
        /// Removes and return random element from list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static T RemoveRandom<T>(this IList<T> list, bool remove = true)
        {
            int randomPos = UnityEngine.Random.Range(0, list.Count);
            var value = list[randomPos];
            if (remove)
            {
                list.RemoveAt(randomPos);
            }
            return value;
        }

        /// <summary>
        /// Shuffles list using Fisher–Yates algorithm
        /// https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void Shuffle<T>(this IList<T> list)
        {
            for (int i = list.Count; i > 0; i--)
            {
                int index = UnityEngine.Random.Range(0, list.Count - i);
                var value = list[i];
                list[i] = list[index];
                list[index] = value;
            }
        }
    }
}
