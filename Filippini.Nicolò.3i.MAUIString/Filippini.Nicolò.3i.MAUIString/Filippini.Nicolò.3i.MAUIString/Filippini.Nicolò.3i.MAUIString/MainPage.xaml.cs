using System.Globalization;

namespace Filippini.Nicolò._3i.MAUIString;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }



    string ToUpperCase(string text)
    {
        char[] chars = text.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            char c = chars[i];
            if (c >= 'a' && c <= 'z')
            {
                chars[i] = (char)(c - 32);
            }
        }
        return new string(chars);
    }

    string ToLowerCase(string text)
    {
        char[] chars = text.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            char c = chars[i];
            if (c >= 'A' && c <= 'Z')
            {
                chars[i] = (char)(c + 32);
            }
        }
        return new string(chars);
    }

    string Reverse(string text)
    {
        char[] chars = text.ToCharArray();
        for (int i = 0, j = text.Length - 1; i < j; i++, j--)
        {
            char temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
        }
        return new string(chars);
    }

    bool Alfabetica(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];
            if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
            {
                return false;
            }
        }
        return true;
    }

    bool Alfanumerica(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];
            if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9')))
            {
                return false;
            }
        }
        return true;
    }
    int NumLettere(string text)
    {
        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                count++;
            }
        }
        return count;
    }



    private void StringBtn(object sender, EventArgs e)
    {
        string input = Input.Text;
        string output = $"Maiuscola: {input.ToUpper()} \n" +
                        $"Minuscola: {input.ToLower()} \n" +
                        $"Contiene solo caratteri Alfabetici? {Alfabetica(input)} \n" +
                        $"Contiene solo caratteri Alfanumerici? {Alfanumerica(input)} \n" +
                        $"Reverse: {Reverse(input)} \n" +
                        $"Numero di lettere: {NumLettere(input)} \n";
        Output.Text = output;
    }




}


