using System;

namespace simple_grading_system
{
    class Program
    {
        static void Main()
        {
            double prelimGrade, midtermGrade, finalGrade, finalAverage;
            Console.Write("Numbers of Student: ");
            int numEntries = Convert.ToInt32(Console.ReadLine());

            while(numEntries>0){

                /*
                    1. Student Personal Data.        
                    ID Number as int idNumber;
                    Student Name as string studentName;
                */
                Console.WriteLine("STUDENT PERSONAL DATA.");
                Console.Write("ID Number: ");
                string idNumber = Console.ReadLine();

                Console.Write("Student Name: ");
                string studentName = Console.ReadLine();

                /*
                    2. Prelim Grade Data.
                    Rating in Quezzes as int prelimQuizRate;
                    Rating in Class Participation as int prelimParticipationRate;
                    Rating in Labaratory Exercises as int prelimLanaratoryExercises;
                    Rating in Project as int prelimProject;
                    Rating in Prelim Exam as in prelimExam;
                */
                Console.WriteLine("\nPRELIM GRADE DATA.\n");
                Console.Write("Rating in Quizzes: ");
                int prelimQuizRate = Convert.ToInt32(Console.ReadLine());

                Console.Write("Rating in Class Participation: ");
                int prelimParticipationRate = Convert.ToInt32(Console.ReadLine());

                Console.Write("Rating in Labaratory Exercises: ");
                int prelimLabaratoryExercises = Convert.ToInt32(Console.ReadLine());

                Console.Write("Rating in Project: ");
                int prelimProject = Convert.ToInt32(Console.ReadLine());

                Console.Write("Rating in Prelim Exam: ");
                int prelimExam = Convert.ToInt32(Console.ReadLine());

                /*
                    3. Midterm Grade Data.
                    Rating in Quezzes as int midQuizRate;
                    Rating in Class Participation as int midParticipationRate;
                    Rating in Labaratory Exercises as int midLanaratoryExercises;
                    Rating in Project as int midProject;
                    Rating in Midterm Exam as in midExam;
                */
                Console.WriteLine("\nMIDTERM GRADE DATA.\n");
                Console.Write("Rating in Quizzes: ");
                int midQuizRate = Convert.ToInt32(Console.ReadLine());

                Console.Write("Rating in Class Participation: ");
                int midParticipationRate = Convert.ToInt32(Console.ReadLine());

                Console.Write("Rating in Labaratory Exercises: ");
                int midLabaratoryExercises = Convert.ToInt32(Console.ReadLine());

                Console.Write("Rating in Project: ");
                int midProject = Convert.ToInt32(Console.ReadLine());

                Console.Write("Rating in Midterm Exam: ");
                int midExam = Convert.ToInt32(Console.ReadLine());

                /*
                    4. Final Grade Data.
                    Rating in Quezzes as int finalQuizRate;
                    Rating in Class Participation as int finalParticipationRate;
                    Rating in Labaratory Exercises as int finalLanaratoryExercises;
                    Rating in Final Exam as in finalExam;
                */
                Console.WriteLine("\nFINAL GRADE DATA.\n");
                Console.Write("Rating in Quizzes: ");
                int finalQuizRate = Convert.ToInt32(Console.ReadLine());

                Console.Write("Rating in Class Participation: ");
                int finalParticipationRate = Convert.ToInt32(Console.ReadLine());

                Console.Write("Rating in Labaratory Exercises: ");
                int finalLabaratoryExercises = Convert.ToInt32(Console.ReadLine());

                Console.Write("Rating in Project: ");
                int finalProject = Convert.ToInt32(Console.ReadLine());

                Console.Write("Rating in Final Exam: ");
                int finalExam = Convert.ToInt32(Console.ReadLine());

                prelimGrade = (prelimQuizRate*.2)+(prelimParticipationRate*.1)+(prelimLabaratoryExercises*.3)+(prelimProject*.1)+(prelimExam*.3);
                midtermGrade = (midQuizRate*.2)+(midParticipationRate*.1)+(midLabaratoryExercises*.3)+(midProject*.1)+(midExam*.3);
                finalGrade = (finalQuizRate*.2)+(finalParticipationRate*.1)+(finalLabaratoryExercises*.3)+(finalProject*.1)+(finalExam*.3);

                finalAverage = (prelimGrade*.2)+(midtermGrade*.3)+(finalGrade*.5);

                Console.Write($"Prelim Grade: {prelimGrade}\nMidterm Grade: {midtermGrade}\nFinal Term Grade: {finalGrade}\nFINAL AVERAGE GRADE: {finalAverage}\n");

                if(finalAverage>=76){
                    Console.WriteLine("REMARKS: PASSED");
                }else{
                    Console.WriteLine("REMARKS: FAILED");
                }

                numEntries--;
                Console.ReadKey(true);
                Console.Clear();
            }    
        }
    }
}
