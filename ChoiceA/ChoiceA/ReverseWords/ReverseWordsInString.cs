namespace ChoiceA.ReverseWords
{
    public class ReverseWordsInString
    {
        public char[] Process(char[] input)
        {            
            int length = input.Length;
            int start = 0;

            for (int i = 0; i < length; i++)
            {
                if (input[i] == ' ' && i > 0)
                {                
                    ReverseWord(input, start, i - 1);
                    start = i + 1;
                }
                else if (i == length - 1)
                {
                    ReverseWord(input, start, i);
                }
            }

            return input;
        }

        public void ReverseWord(char[] stringToReverse, int start, int end)
        {
            while (start < end)
            {
                var temp = stringToReverse[start];
                stringToReverse[start] = stringToReverse[end];
                stringToReverse[end] = temp;
                start++;
                end--;
            }
        }
    }
}
