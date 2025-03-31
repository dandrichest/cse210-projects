using System;

namespace Homework;

public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";
    public string GetTextbookSection()
    {
        return _textbookSection;
    }

    public void SetTextbookSection(string textbooksection)
    {
        _textbookSection = textbooksection;
    }

    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"{_textbookSection} {_problems}";
    }

}

