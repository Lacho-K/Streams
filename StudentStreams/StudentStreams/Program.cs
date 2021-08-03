using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace StudentStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, float> studentsInfo = new Dictionary<string, float>();

            using (StreamReader reader = new StreamReader("students.txt"))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    string[] input = line.Split();
                    studentsInfo.Add(input[0], float.Parse(input[1]));
                }
            }

            using (StreamWriter writer = new StreamWriter("studentsSorted.txt"))
            {
                foreach (var student in studentsInfo.OrderBy(x => x.Key).ThenBy(x => x.Value))
                {
                    writer.WriteLine($"{student.Key} {student.Value}");
                }
            }            

        }
    }
}
