using System;
using System.Collections.Generic;

using System.Linq;

namespace T10SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessonsSchedule = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string commands = Console.ReadLine();

            while (commands != "course start")
            {
                string[] subcommands = commands.Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string lessonTitle1 = subcommands[1];
                int indexOfLessonTitle1 = lessonsSchedule.IndexOf(lessonTitle1);



                if (subcommands[0] == "Exercise")
                {
                    if (lessonsSchedule.Contains(lessonTitle1) &&
                            !lessonsSchedule.Contains($"{lessonTitle1}-Exercise"))
                    {

                        lessonsSchedule.Insert(indexOfLessonTitle1 + 1, $"{lessonTitle1}-Exercise");
                    }

                    else if (!lessonsSchedule.Contains(lessonTitle1))

                    {
                        lessonsSchedule.Add(lessonTitle1);
                        lessonsSchedule.Add($"{lessonTitle1}-Exercise");

                    }
                }

                if (subcommands[0] == "Add")
                {
                    if (!lessonsSchedule.Contains(lessonTitle1))
                    {
                        lessonsSchedule.Add(lessonTitle1);

                    }
                }

                if (subcommands[0] == "Insert")
                {
                    int index = int.Parse(subcommands[2]);

                    if (!lessonsSchedule.Contains(lessonTitle1))
                    {
                        lessonsSchedule.Insert(index, lessonTitle1);

                    }

                }

                if (subcommands[0] == "Remove")
                {

                    lessonsSchedule.Remove(lessonTitle1);
                    lessonsSchedule.Remove($"{lessonTitle1}-Exercise");

                }

                if (subcommands[0] == "Swap")
                {
                    string lessonTitle2 = subcommands[2];
                    int indexOfLessonTitle2 = lessonsSchedule.IndexOf(lessonTitle2);

                    if (lessonsSchedule.Contains(lessonTitle1) && lessonsSchedule.Contains(lessonTitle2))
                    {
                        string tempLesson1 = lessonsSchedule[indexOfLessonTitle1];
                        lessonsSchedule[indexOfLessonTitle1] = lessonsSchedule[indexOfLessonTitle2];
                        lessonsSchedule[indexOfLessonTitle2] = tempLesson1;

                        indexOfLessonTitle1 = lessonsSchedule.IndexOf(lessonTitle1);
                        indexOfLessonTitle2 = lessonsSchedule.IndexOf(lessonTitle2);

                        if (lessonsSchedule.Contains($"{lessonTitle1}-Exercise"))
                        {
                            lessonsSchedule.Remove($"{lessonTitle1}-Exercise");
                            lessonsSchedule.Insert(indexOfLessonTitle1 + 1, $"{lessonTitle1}-Exercise");
                        }
                        if (lessonsSchedule.Contains($"{lessonTitle2}-Exercise"))
                        {

                            lessonsSchedule.Remove($"{lessonTitle2}-Exercise");
                            lessonsSchedule.Insert(indexOfLessonTitle2 + 1, $"{lessonTitle2}-Exercise");
                        }

                    }
                    
                }
                
                commands = Console.ReadLine();
            }

            for (int i = 0; i < lessonsSchedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessonsSchedule[i]}");
            }


        }
    }
}
