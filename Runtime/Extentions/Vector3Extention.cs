using UnityEditor;
using UnityEngine;

namespace Unknown.HelperTools.Extentions
{
    public static class Vector3Extention
    {
        /// <summary>
        /// Returns a copy of this vector3 with changed values
        /// </summary>
        /// <param name="original"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static Vector3 WithValues(this Vector3 original, float? x = null, float? y = null, float? z = null)
        {
            return new Vector3(x ?? original.x, y ?? original.y, z ?? original.z);
        }
        
        /// <summary>
        /// Returns Vector3, the direction from one point to another
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 DirectionTo(this Vector3 start, Vector3 destination)
        {
            return (start - destination);
        }

        /// <summary>
        /// Returns normalized Vector3 (magnitute of 1), the direction from one point to another
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 NormalDirectionTo(this Vector3 start, Vector3 destination)
        {
            return (start - destination).normalized;
        }

        /// <summary>
        /// Returns Vector3, the direction from one point to another
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 DirectionTo(this Vector3 start, Transform destination)
        {
            return start.DirectionTo(destination.position);
        }

        /// <summary>
        /// Returns normalized Vector3 (magnitute of 1), the direction from one point to another
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 NormalDirectionTo(this Vector3 start, Transform destination)
        {
            return start.NormalDirectionTo(destination.position);
        }

        /// <summary>
        /// Returns Vector3, the direction from one point to another
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 DirectionTo(this Vector3 start, GameObject destination)
        {
            return start.DirectionTo(destination.transform.position);
        }

        /// <summary>
        /// Returns normalized Vector3 (magnitute of 1), the direction from one point to another
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 NormalDirectionTo(this Vector3 start, GameObject destination)
        {
            return start.NormalDirectionTo(destination.transform.position);
        }

        /// <summary>
        /// Returns float, distance between 2 points
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static float DistanceTo(this Vector3 start, Vector3 destination)
        {
            return Vector3.Magnitude(destination - start);
        }

        /// <summary>
        /// Returns float, distance between 2 points
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static float DistanceTo(this Vector3 start, Transform destination)
        {
            return Vector3.Magnitude(destination.position - start);
        }

        /// <summary>
        /// Returns float, distance between 2 points
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static float DistanceTo(this Vector3 start, GameObject destination)
        {
            return Vector3.Magnitude(destination.transform.position - start);
        }

        /// <summary>
        /// Return true if vector point to same direction 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static bool sameDirection(this Vector3 first, Vector3 second)
        {
            return (first.normalized == second.normalized);
        }
    }
}
