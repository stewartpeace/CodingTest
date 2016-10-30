using System;

namespace SkeletonCode.ReversingString
{
	public class StringUtilities
	{
		public string Reverse(string input)
		{
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;
            
            var inputArray = input.ToCharArray();

            Array.Reverse(inputArray);
            
			return new string(inputArray);
		}
	}
}
