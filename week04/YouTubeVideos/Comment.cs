using System;

public class Comment
{
    public string _commenterName;
    public string _text;

    public string GetDisplayText()
    {
        return $"{_commenterName}: \"{_text}\"";
    }
}