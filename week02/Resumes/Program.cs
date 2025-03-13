using System;
using Resumes;

class Program
{
    static void Main(string[] args)
    {
        // Create and initialize job1
        Job job1 = new Job
        {
            _company = "Microsoft",
            _jobTitle = "Software Engineer",
            _startYear = 2000,
            _endYear = 2028
        };

        // Create and initialize job2
        Job job2 = new Job
        {
            _company = "Apple",
            _jobTitle = "Computer Engineer",
            _startYear = 2000,
            _endYear = 2027
        };

        // Create and initialize Resume
        Resume myResume = new Resume
        {
            _name = "John Stone"
        };
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display Resume details (name first, then jobs)
        myResume.ResumeDetails();
    }
}
