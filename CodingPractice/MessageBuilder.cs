using System;

public class MessageBuilder
{
    private string _message = "";

    public MessageBuilder AddText(string text)
    {
        _message += text;
        return this;  // 자기 자신 반환
    }

    public MessageBuilder AddSpace()
    {
        _message += " ";
        return this;
    }

    public MessageBuilder AddNewLine()
    {
        _message += "\n";
        return this;
    }

    public string Build()
    {
        return _message;
    }
}