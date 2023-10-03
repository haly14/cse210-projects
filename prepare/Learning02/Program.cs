using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Junior Software Developer";
        job1._company = "Microsoft";
        job1._startYear = 2015;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "AI Software Developer";
        job2._company = "Google";
        job2._startYear = 2018;
        job2._endYear = 2023;


    }
}