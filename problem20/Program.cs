

//iterate through the string.
// If the character is a opening bracket of any type, push it onto the stack
// if it is a closing bracket, pop the last element off the stack and verify that they are equal
// after reaching the end of the string, the stack should be empty.
static bool IsValid(string s)
{
    Stack<char> stack = new Stack<char>();



    foreach (var c in s.ToCharArray())
    {
        if(c == '(' || c == '[' || c == '{'){
            stack.Push(c);
        }else{
            if(stack.Count == 0)
                return false;
                
            var popped = stack.Pop();
            switch (c)
            {
                case ')':
                    if (popped != '(')
                        return false;
                    break;
                case ']':
                    if (popped != '[')
                        return false;
                    break;
                case '}':
                    if (popped != '{')
                        return false;
                    break;
                default:
                    break;
            }
        }
        
    }

    return stack.Count == 0;
}

Console.WriteLine(IsValid("()"));
Console.WriteLine(IsValid("()[]{}"));
Console.WriteLine(IsValid("(]"));
Console.WriteLine(IsValid("([])"));