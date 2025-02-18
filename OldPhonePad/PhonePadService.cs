using System;
namespace PhoneKeyPad
{
	public class PhonePadService
	{
		private static readonly Dictionary<char, char[]> values = new Dictionary<char, char[]>();
        
        public PhonePadService()
        {
            values.TryAdd('1', new char[] { '&', '\'', '(' });
            values.TryAdd('2', new char[] { 'A', 'B', 'C' });
            values.TryAdd('3', new char[] { 'D', 'E', 'F' });
            values.TryAdd('4', new char[] { 'G', 'H', 'I' });
            values.TryAdd('5', new char[] { 'J', 'K', 'L' });
            values.TryAdd('6', new char[] { 'M', 'N', 'O' });
            values.TryAdd('7', new char[] { 'P', 'Q', 'R', 'S' });
            values.TryAdd('8', new char[] { 'T', 'U', 'V' });
            values.TryAdd('9', new char[] { 'W', 'X', 'Y', 'Z' });
            values.TryAdd('0', new char[] { ' ' });
        }

		public static String OldPhonePad(string input)
		{
            //added the predefined data and decided to set Dictionary format for data structure
            values.TryAdd('1', new char[] { '&', '\'', '(' });
            values.TryAdd('2', new char[] { 'A', 'B', 'C' });
            values.TryAdd('3', new char[] { 'D', 'E', 'F' });
            values.TryAdd('4', new char[] { 'G', 'H', 'I' });
            values.TryAdd('5', new char[] { 'J', 'K', 'L' });
            values.TryAdd('6', new char[] { 'M', 'N', 'O' });
            values.TryAdd('7', new char[] { 'P', 'Q', 'R', 'S' });
            values.TryAdd('8', new char[] { 'T', 'U', 'V' });
            values.TryAdd('9', new char[] { 'W', 'X', 'Y', 'Z' });
            values.TryAdd('0', new char[] { ' ' });

            string data = string.Empty;
            int pressCount = 1;
            char prevChar = char.MinValue;
            foreach(char c in input)
            {
                if(c == prevChar || c == '*')
                {
                    data = data.Remove(data.Length - 1);
                    pressCount = c == '*' ? 1 : ++pressCount;
                }
                else
                {
                    pressCount = 1;
                }
                if (c == ' ' || c == '*')
                {
                    prevChar = c;
                    continue;
                }

                if (c == '#')
                {
                    break;
                }
                
                data += GetCharacter(c, pressCount);
                prevChar = c;
            }
            return data;
		}

        private static char GetCharacter(char input, int pressCount)
		{
            return values.Where(x => x.Key == input).Select(x => x.Value[pressCount - 1]).FirstOrDefault();
		}
    }
}

