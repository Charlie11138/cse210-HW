using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Team Member";
        job1._company = "Chick-fil-A";
        job1._startYear = 2011;
        job1._endYear = 2014;

        Job job2 = new Job();
        job2._jobTitle = "Team Leader";
        job2._company = "Chick-fil-A";
        job2._startYear = 2014;
        job2._endYear = 2017;

        Job job3 = new Job();
        job3._jobTitle = "Picker";
        job3._company = "TVH";
        job3._startYear = 2015;
        job3._endYear = 2016;
        
        Resume resume1 = new Resume();
        resume1._name = "Charlie Mitts";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._jobs.Add(job3);
        resume1.Display();
    }
    
    
}