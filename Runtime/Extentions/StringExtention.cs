using UnityEngine;


namespace Unknown.HelperTools.Extentions
{
	public static class StringExtention
	{
		public static string Colorful(this string text, Color color)
		{ 
			return $"<color=#{ColorUtility.ToHtmlStringRGB(color)}>{text}</color>";
		}
	}
}
