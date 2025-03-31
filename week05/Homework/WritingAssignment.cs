using System;

namespace Homework;

public class WrittingAssignment : Assignment
{
    private string _subtopic = "";
    public string GetSubtopic()
    {
        return _subtopic;
    }

    public void SetSubtopic(string subtopic)
    {
        _subtopic = subtopic;
    }

    public string GetWritingInformation()
    {
        return $"{_subtopic}";
    }
}
