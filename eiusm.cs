// A function that reverses a string
public static string ReverseString(string input)
{
    // Initialize an empty string to store the result
    string result = "";

    // Loop through the input string from the end to the beginning
    for (int i = input.Length - 1; i >= 0; i--)
    {
        // Append each character to the result string
        result += input[i];
    }

    // Return the reversed string
    return result;
}
