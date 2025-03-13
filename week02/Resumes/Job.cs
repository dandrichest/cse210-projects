using System;

namespace Resumes
{
    public class Job
    {
        // Fields
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;

        // Method to display job details
        internal void DisplayJobDetails()
        {
            Console.WriteLine($"{_jobTitle} at {_company} from {_startYear} to {_endYear}");
        }
    }
}
