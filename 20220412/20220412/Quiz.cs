public class Solution
{
    public bool solution(string s)
    {
        Stack<string> stack = new Stack<string>();

        foreach (char word in s)
        {

            if (word == '(')
            {
                stack.Push(word.ToString());
                continue;
            }

            
            if (stack.Count == 0)
            {
                return false;
            }


            stack.Pop();
        }


        return stack.Count == 0;
    }
}