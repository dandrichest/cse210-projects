using System;

namespace Homework;
class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Shola");
        assignment1.SetTopic("Subtraction");

        MathAssignment assignment2 = new MathAssignment();
        assignment2.SetStudentName("Segun Oba");
        assignment2.SetTopic("Multiplication");
        assignment2.SetTextbookSection("Section 7.1");
        assignment2.SetProblems("Problems 1-10");

        WrittingAssignment assignment3 = new WrittingAssignment();
        assignment3.SetStudentName("Amarachi Nwogu");
        assignment3.SetTopic("African History");
        assignment3.SetSubtopic("African Almagamation");

        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}