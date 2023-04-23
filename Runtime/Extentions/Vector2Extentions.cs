using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

namespace Unknown.HelperTools.Extentions
{
    public static class Vector2Extentions
    {
        /// <summary>
        /// Returns a copy of this Vector2 with changed values
        /// </summary>
        /// <param name="original"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Vector2 WithValues(this Vector2 vector, float? x = null, float? y = null)
        {
            return new Vector2(x ?? vector.x, y ?? vector.y);
        }

        /// <summary>
        /// Returns Vector2, the direction from one point to another
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector2 DirectionTo(this Vector2 start, Vector2 destination)
        {
            return start - destination;
        }

        /// <summary>
        /// Returns normalized Vector2 (magnitute of 1), the direction from one point to another
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector2 NormalDirectionTo(this Vector2 start, Vector2 destination)
        {
            return (start - destination).normalized;
        }

        /// <summary>
        /// Returns Vector2, the direction from one point to another
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector2 DirectionTo(this Vector2 start, Transform destination)
        {
            return start.DirectionTo(destination.position);
        }

        /// <summary>
        /// Returns normalized Vector2 (magnitute of 1), the direction from one point to another
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector2 NormalDirectionTo(this Vector2 start, Transform destination)
        {
            return start.NormalDirectionTo(destination.position);
        }

        /// <summary>
        /// Returns Vector2, the direction from one point to another
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector2 DirectionTo(this Vector2 start, GameObject destination)
        {
            return start.DirectionTo(destination.transform.position);
        }

        /// <summary>
        /// Returns normalized Vector2 (magnitute of 1), the direction from one point to another
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector2 NormalDirectionTo(this Vector2 start, GameObject destination)
        {
            return start.NormalDirectionTo(destination.transform.position);
        }

        /// <summary>
        /// Return float, distance between 2 points
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static float DistanceTo(this Vector2 start, Vector2 destination)
        {
            return Vector2.Distance(start, destination);
        }

        /// <summary>
        /// Return float, distance between 2 points
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static float DistanceTo(this Vector2 start, Transform destination)
        {
            return Vector2.Distance(start, destination.position);
        }

        /// <summary>
        /// Return float, distance between 2 points
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static float DistanceTo(this Vector2 start, GameObject destination)
        {
            return Vector2.Distance(start, destination.transform.position);
        }

        /// <summary>
        /// Return true if vectors point to same direction 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static bool sameDirection(this Vector2 first, Vector2 second)
        {
            return (first.normalized == second.normalized);
        }

    }
}
