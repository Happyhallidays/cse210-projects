public class FlaggedString
{
    public string Text { get; set; }
    public bool Used { get; set; } = false;

    public FlaggedString(string text)
    {
        Text = text;
    }
}