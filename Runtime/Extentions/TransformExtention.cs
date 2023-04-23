using UnityEngine;


namespace Unknown.HelperTools.Extentions
{
    public static class TransformExtention
    {
        /// <summary>
        /// Destroys every child of this transform
        /// </summary>
        /// <param name="transform"></param>
        public static void DestroyChildren(this Transform transform)
        {
            foreach(Transform child in transform)
            {
                Object.Destroy(child);
            }
        }

        /// <summary>
        /// Returns Vector3, the direction between 2 points
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 DirectionTo(this Transform start, Vector3 destination)
        {
            return start.position.DirectionTo(destination);
        }

        /// <summary>
        /// Returns normalized Vector3, the direction between 2 points
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 NormalDirectionTo(this Transform start, Vector3 destination)
        {
            return start.position.NormalDirectionTo(destination);
        }

        /// <summary>
        /// Returns Vector3, the direction between 2 points
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 DirectionTo(this Transform start, Transform destination)
        {
            return start.position.DirectionTo(destination.position);
        }

        /// <summary>
        /// Returns normalized Vector3, the direction between 2 points
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 NormalDirectionTo(this Transform start, Transform destination)
        {
            return start.position.NormalDirectionTo(destination.position);
        }

        /// <summary>
        /// Returns Vector3, the direction between 2 points
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 DirectionTo(this Transform start, GameObject destination)
        {
            return start.position.DirectionTo(destination.transform.position);
        }

        /// <summary>
        /// Returns normalized Vector3, the direction between 2 points
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 NormalDirectionTo(this Transform start, GameObject destination)
        {
            return start.position.NormalDirectionTo(destination.transform.position);
        }

        /// <summary>
        /// Returns distance between 2 points as float
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static float DistanceTo(this Transform start, Vector3 destination)
        {
            return start.position.DistanceTo(destination);
        }

        /// <summary>
        /// Returns distance between 2 points as float
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static float DistanceTo(this Transform start, Transform destination)
        {
            return start.position.DistanceTo(destination.position);
        }

        /// <summary>
        /// Returns distance between 2 points as float
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static float DistanceTo(this Transform start, GameObject destination)
        {
            return start.position.DistanceTo(destination.transform.position);
        }
    }
}
