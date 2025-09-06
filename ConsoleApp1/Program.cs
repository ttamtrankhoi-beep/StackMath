// See https://aka.ms/new-console-template for more information
static bool IsChuoiNgoac(string str)
{
    Stack<char> stack = new Stack<char>();
    Dictionary<char, char> pairC = new Dictionary<char, char>() {
        {')','(' },
        {']','[' },
        {'}','{' }
    };
    foreach (char c in str)
    {
        if (c == '(' || c == '[' || c == '{')
        {
            stack.Push(c);
        }
        else if (stack.Count==0 || ((c == ')' || c == ']' || c == '}')))
        {
            if (stack.Peek() != pairC[c]) { return false; }
            stack.Pop();
        }
    }
    return stack.Count == 0;
}
string str = "{[}}";//False
string str2 = "{[()]}";
Console.WriteLine(IsChuoiNgoac(str2));
Console.ReadLine();