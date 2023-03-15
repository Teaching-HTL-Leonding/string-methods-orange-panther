Welcome(out char indexOf, out char trim);
DoMainProgram(indexOf, trim);

void Welcome(out char indexOf, out char trim)
{
    bool inputIsValid = true;
    Console.Clear();
    Console.WriteLine("String Methods\n**************************************************");
    do
    {
        Console.Write("Char for \"IndexOf\": ");
        indexOf = Console.ReadKey().KeyChar;
        Console.Write("\nChar for \"Trim\":    ");
        trim = Console.ReadKey().KeyChar;
        inputIsValid = true;
        if (indexOf is ' ' || trim is ' ')
        {
            inputIsValid = false;
        }
        Console.WriteLine();
    } while (!inputIsValid);
}

void DoMainProgram(char indexOf, char trim)
{
    string text;
    int substringStart = 2, substringLength = 2;
    int startRemove = 2, removeLength = 2;
    do
    {
        Console.Write("\nString: ");
        text = Console.ReadLine()!;

        if (string.IsNullOrEmpty(text)) { return; }

        Console.WriteLine($"IndexOf(\"{text}\", \'{indexOf}\', 0):    = {IndexOf(text, indexOf)}");
        Console.WriteLine($"LastIndexOf(\"{text}\", \'{indexOf}\'):   = {LastIndexOf(text, indexOf)}");
        Console.WriteLine($"Contains(\"{text}\", \'{indexOf}\'):      = {Contains(text, indexOf)}");
        Console.WriteLine($"TrimStart(\"{text}\", \'{trim}\'):     = \"{TrimStart(text, trim)}\"");
        Console.WriteLine($"TrimEnd(\"{text}\", \'{trim}\'):       = \"{TrimEnd(text, trim)}\"");
        Console.WriteLine($"Trim(\"{text}\", \'{trim}\'):          = \"{Trim(text, trim)}\"");
        Console.WriteLine($"SubString(\"{text}\", {substringStart}, {substringLength}):    = \"{SubString(text, substringStart, substringLength)}\"");
        Console.WriteLine($"Remove(\"{text}\", {startRemove}, {removeLength}):       = \"{Remove(text, startRemove, removeLength)}\"");
    } while (true);

}

bool Contains(string text, char indexOf)
{
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == indexOf)
        {
            return true;
        }
    }
    return false;
}

int IndexOf(string text, char indexOf)
{
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == indexOf)
        {
            return i;
        }
    }
    return -1;
}

int LastIndexOf(string text, char indexOf)
{
    for (int i = text.Length - 1; i >= 0; i--)
    {
        if (text[i] == indexOf)
        {
            return i;
        }
    }
    return -1;
}

string TrimStart(string text, char trim)
{
    for (int i = 0; i < text.Length;)
    {
        if (text[i] != trim)
        {
            return text;
        }
        else
        {
            text = text[(i + 1)..];
        }
    }
    return text;
}

string TrimEnd(string text, char trim)
{
    for (int i = text.Length - 1; i >= 0; i--)
    {
        if (text[i] != trim)
        {
            return text;
        }
        else
        {
            text = text[..i];
        }
    }
    return text;
}

string Trim(string text, char trim)
{
    text = TrimStart(text, trim);
    text = TrimEnd(text, trim);
    return text;
}

string SubString(string text, int startIndex, int substringLength)
{
    string substring = "";
    for (int i = startIndex; i - startIndex < substringLength; i++)
    {
        if (i < text.Length)
        {
            substring += text[i];
        }
    }
    return substring;
}

string Remove(string text, int startIndex, int removeLength)
{
    if (removeLength <= text.Length - startIndex)
    {
        text = text[..startIndex] + text[(startIndex + removeLength)..];
    }
    else
    {
        text = text[..startIndex];
    }
    return text;
}
