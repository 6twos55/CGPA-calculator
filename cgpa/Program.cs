// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lessonFive
{
    class GPA
    {

        public GPA(string semester)
        {
            Console.WriteLine("Student's Semester {0} CGPA calculator \n", semester);

            Console.WriteLine("How many courses did you offer in semester {0}:", semester);
            int courseNum = Int32.Parse(Console.ReadLine());

            string[,] coursesOffered = new string[courseNum, 5];
            int[,] totalPoints = new int[courseNum, 5];

            string courseCode;
            string courseTitle;
            string courseUnit;
            string testScore;
            string examScore;

            int point0 = 0;
            int point1 = 1;
            int point2 = 2;
            int point3 = 3;
            int point4 = 4;
            int point5 = 5;

            int courseTotalPoints;
            int aggregateOne;




            for (int i = 0; i < courseNum; i++)
            {
                Console.WriteLine("Enter course {0}'s code: ", i + 1);
                courseCode = Console.ReadLine();
                coursesOffered[i, 0] = courseCode;


                Console.WriteLine("Enter course {0}'s title: ", i + 1);
                courseTitle = Console.ReadLine();
                coursesOffered[i, 1] = courseTitle;

                Console.WriteLine("Enter course {0}'s course unit", i + 1);
                courseUnit = Console.ReadLine();
                coursesOffered[i, 2] = courseUnit;

                Console.WriteLine("Enter course {0}'s test score: ", i + 1);
                testScore = Console.ReadLine();
                coursesOffered[i, 3] = testScore;


                Console.WriteLine("Enter course {0}'s exam score: ", i + 1);
                examScore = Console.ReadLine();
                coursesOffered[i, 4] = examScore;
            }


            Console.WriteLine("\nNo\tCourse Code\tCourse Title\tCourse Unit\tTest Scores\tExam Scores: ");

            for (int i = 0; i < coursesOffered.Length / 5; i++)
            {
                Console.WriteLine();
                Console.Write("{0}.\t", i + 1);

                for (int j = 0; j < coursesOffered.Length / courseNum; j++)
                {
                    Console.Write(coursesOffered[i, j] + "\t \t");
                }
            }
            Console.WriteLine();

            Console.WriteLine("\n \n Coure Title \tGrade\t\tPoints\t\tTotal Points");

            for (int i = 0; i < courseNum; i++)
            {
                string title = coursesOffered[i, 1];
                int unitIntScore = Int32.Parse(coursesOffered[i, 2]);
                int testIntScore = Int32.Parse(coursesOffered[i, 3]);
                int examIntScore = Int32.Parse(coursesOffered[i, 4]);

                char gradeA = 'A';
                char gradeB = 'B';
                char gradeC = 'C';
                char gradeD = 'D';
                char gradeE = 'E';
                char gradeF = 'F';

                if (testIntScore + examIntScore >= 70 && testIntScore + examIntScore <= 100)
                {
                    courseTotalPoints = point5 * unitIntScore;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", title, gradeA, point5, courseTotalPoints);
                    totalPoints[i, 0] = courseTotalPoints;

                }
                else if (testIntScore + examIntScore >= 60 && testIntScore + examIntScore < 70)
                {
                    courseTotalPoints = point4 * unitIntScore;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", title, gradeB, point4, courseTotalPoints);
                    totalPoints[i, 0] = courseTotalPoints;

                }
                else if (testIntScore + examIntScore >= 50 && testIntScore + examIntScore <= 59)
                {
                    courseTotalPoints = point3 * unitIntScore;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", title, gradeC, point3, courseTotalPoints);
                    totalPoints[i, 0] = courseTotalPoints;

                }
                else if (testIntScore + examIntScore >= 45 && testIntScore + examIntScore <= 49)
                {
                    courseTotalPoints = point2 * unitIntScore;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", title, gradeD, point2, courseTotalPoints);
                    totalPoints[i, 0] = courseTotalPoints;

                }
                else if (testIntScore + examIntScore >= 40 && testIntScore + examIntScore < 44)
                {
                    courseTotalPoints = point1 * unitIntScore;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", title, gradeE, point1, courseTotalPoints);
                    totalPoints[i, 0] = courseTotalPoints;

                }
                else if (testIntScore + examIntScore < 40)
                {
                    courseTotalPoints = 0;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", title, gradeF, point0, courseTotalPoints);
                    totalPoints[i, 0] = courseTotalPoints;

                }

            }
            Console.WriteLine("\n\n");


            //Aggregate Score
            aggregateOne = totalPoints[0, 0];

            for (int i = 0; i < courseNum - 1; i++)
            {
                aggregateOne += totalPoints[i + 1, 0];
            }

            int CGPA = aggregateOne / courseNum;

            Console.WriteLine("Aggregate Score For Semester {0} is : {1}", semester, aggregateOne);
            Console.WriteLine("CGPA for semester {0} is : {1}", semester, CGPA);


        }

    }

    class Session
    {
        public Session()
        {

            //SEMESTER ONE
            Console.WriteLine("Student's GPA calculator \n");
            Console.WriteLine("Semester One.");
            Console.WriteLine("How many courses did you offer in semester One:");
            int courseNum = Int32.Parse(Console.ReadLine());

            string[,] coursesOffered = new string[courseNum, 5];
            int[,] totalPoints = new int[courseNum, 5];

            string courseCode;
            string courseTitle;
            string courseUnit;
            string testScore;
            string examScore;

            int point0 = 0;
            int point1 = 1;
            int point2 = 2;
            int point3 = 3;
            int point4 = 4;
            int point5 = 5;

            int courseTotalPoints;
            int aggregateOne;




            for (int i = 0; i < courseNum; i++)
            {
                Console.WriteLine("Enter course {0}'s code: ", i + 1);
                courseCode = Console.ReadLine();
                coursesOffered[i, 0] = courseCode;


                Console.WriteLine("Enter course {0}'s title: ", i + 1);
                courseTitle = Console.ReadLine();
                coursesOffered[i, 1] = courseTitle;

                Console.WriteLine("Enter course {0}'s course unit", i + 1);
                courseUnit = Console.ReadLine();
                coursesOffered[i, 2] = courseUnit;

                Console.WriteLine("Enter course {0}'s test score: ", i + 1);
                testScore = Console.ReadLine();
                coursesOffered[i, 3] = testScore;


                Console.WriteLine("Enter course {0}'s exam score: ", i + 1);
                examScore = Console.ReadLine();
                coursesOffered[i, 4] = examScore;
            }


            Console.WriteLine("\nNo\tCourse Code\tCourse Title\tCourse Unit\tTest Scores\tExam Scores: ");

            for (int i = 0; i < coursesOffered.Length / 5; i++)
            {
                Console.WriteLine();
                Console.Write("{0}.\t", i + 1);

                for (int j = 0; j < coursesOffered.Length / courseNum; j++)
                {
                    Console.Write(coursesOffered[i, j] + "\t \t");
                }
            }
            Console.WriteLine();

            Console.WriteLine("\n \n Coure Title \tGrade\t\tPoints\t\tTotal Points");

            for (int i = 0; i < courseNum; i++)
            {
                string title = coursesOffered[i, 1];
                int unitIntScore = Int32.Parse(coursesOffered[i, 2]);
                int testIntScore = Int32.Parse(coursesOffered[i, 3]);
                int examIntScore = Int32.Parse(coursesOffered[i, 4]);

                char gradeA = 'A';
                char gradeB = 'B';
                char gradeC = 'C';
                char gradeD = 'D';
                char gradeE = 'E';
                char gradeF = 'F';

                if (testIntScore + examIntScore >= 70 && testIntScore + examIntScore <= 100)
                {
                    courseTotalPoints = point5 * unitIntScore;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", title, gradeA, point5, courseTotalPoints);
                    totalPoints[i, 0] = courseTotalPoints;

                }
                else if (testIntScore + examIntScore >= 60 && testIntScore + examIntScore < 70)
                {
                    courseTotalPoints = point4 * unitIntScore;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", title, gradeB, point4, courseTotalPoints);
                    totalPoints[i, 0] = courseTotalPoints;

                }
                else if (testIntScore + examIntScore >= 50 && testIntScore + examIntScore <= 59)
                {
                    courseTotalPoints = point3 * unitIntScore;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", title, gradeC, point3, courseTotalPoints);
                    totalPoints[i, 0] = courseTotalPoints;

                }
                else if (testIntScore + examIntScore >= 45 && testIntScore + examIntScore <= 49)
                {
                    courseTotalPoints = point2 * unitIntScore;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", title, gradeD, point2, courseTotalPoints);
                    totalPoints[i, 0] = courseTotalPoints;

                }
                else if (testIntScore + examIntScore >= 40 && testIntScore + examIntScore < 44)
                {
                    courseTotalPoints = point1 * unitIntScore;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", title, gradeE, point1, courseTotalPoints);
                    totalPoints[i, 0] = courseTotalPoints;

                }
                else if (testIntScore + examIntScore < 40)
                {
                    courseTotalPoints = 0;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", title, gradeF, point0, courseTotalPoints);
                    totalPoints[i, 0] = courseTotalPoints;

                }

            }
            Console.WriteLine("\n\n");


            //Aggregate Score One
            aggregateOne = totalPoints[0, 0];

            for (int i = 0; i < courseNum - 1; i++)
            {
                aggregateOne += totalPoints[i + 1, 0];
            }

            int CGPA = aggregateOne / courseNum;

            Console.WriteLine("Aggregate Score For Semester One is : {0}",  aggregateOne);
            Console.WriteLine("CGPA for semester One is : {0}", CGPA);









            //SEMESTER TWO

            Console.WriteLine("Semester Two.");

            Console.WriteLine("How many courses did you offer in semester Two:");
            int courseNumTwo = Int32.Parse(Console.ReadLine());

            string[,] coursesOfferedTwo = new string[courseNumTwo, 5];
            int[,] totalPointsTwo = new int[courseNumTwo, 5];

            string courseCodeTwo;
            string courseTitleTwo;
            string courseUnitTwo;
            string testScoreTwo;
            string examScoreTwo;

            int point0Two = 0;
            int point1Two = 1;
            int point2Two = 2;
            int point3Two = 3;
            int point4Two = 4;
            int point5Two = 5;

            int courseTotalPointsTwo;
            int aggregateTwo;




            for (int i = 0; i < courseNumTwo; i++)
            {
                Console.WriteLine("Enter course {0}'s code: ", i + 1);
                courseCodeTwo = Console.ReadLine();
                coursesOfferedTwo[i, 0] = courseCodeTwo;


                Console.WriteLine("Enter course {0}'s title: ", i + 1);
                courseTitleTwo = Console.ReadLine();
                coursesOfferedTwo[i, 1] = courseTitleTwo;

                Console.WriteLine("Enter course {0}'s course unit", i + 1);
                courseUnitTwo = Console.ReadLine();
                coursesOfferedTwo[i, 2] = courseUnitTwo;

                Console.WriteLine("Enter course {0}'s test score: ", i + 1);
                testScoreTwo = Console.ReadLine();
                coursesOfferedTwo[i, 3] = testScoreTwo;


                Console.WriteLine("Enter course {0}'s exam score: ", i + 1);
                examScoreTwo = Console.ReadLine();
                coursesOfferedTwo[i, 4] = examScoreTwo;
            }


            Console.WriteLine("\nNo\tCourse Code\tCourse Title\tCourse Unit\tTest Scores\tExam Scores: ");

            for (int i = 0; i < coursesOfferedTwo.Length / 5; i++)
            {
                Console.WriteLine();
                Console.Write("{0}.\t", i + 1);

                for (int j = 0; j < coursesOfferedTwo.Length / courseNumTwo; j++)
                {
                    Console.Write(coursesOfferedTwo[i, j] + "\t \t");
                }
            }
            Console.WriteLine();

            Console.WriteLine("\n \n Coure Title \tGrade\t\tPoints\t\tTotal Points");

            for (int i = 0; i < courseNumTwo; i++)
            {
                string titleTwo = coursesOfferedTwo[i, 1];
                int unitIntScoreTwo = Int32.Parse(coursesOfferedTwo[i, 2]);
                int testIntScoreTwo = Int32.Parse(coursesOfferedTwo[i, 3]);
                int examIntScoreTwo = Int32.Parse(coursesOfferedTwo[i, 4]);

                char gradeATwo = 'A';
                char gradeBTwo = 'B';
                char gradeCTwo = 'C';
                char gradeDTwo = 'D';
                char gradeETwo = 'E';
                char gradeFTwo = 'F';

                if (testIntScoreTwo + examIntScoreTwo >= 70 && testIntScoreTwo + examIntScoreTwo <= 100)
                {
                    courseTotalPointsTwo = point5Two * unitIntScoreTwo;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", titleTwo, gradeATwo, point5Two, courseTotalPointsTwo);
                    totalPointsTwo[i, 0] = courseTotalPointsTwo;

                }
                else if (testIntScoreTwo + examIntScoreTwo >= 60 && testIntScoreTwo + examIntScoreTwo < 70)
                {
                    courseTotalPointsTwo = point4Two * unitIntScoreTwo;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", titleTwo, gradeBTwo, point4Two, courseTotalPointsTwo);
                    totalPointsTwo[i, 0] = courseTotalPointsTwo;

                }
                else if (testIntScoreTwo + examIntScoreTwo >= 50 && testIntScoreTwo + examIntScoreTwo <= 59)
                {
                    courseTotalPointsTwo = point3Two * unitIntScoreTwo;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", titleTwo, gradeCTwo, point3Two, courseTotalPointsTwo);
                    totalPointsTwo[i, 0] = courseTotalPointsTwo;

                }
                else if (testIntScoreTwo + examIntScoreTwo >= 45 && testIntScoreTwo + examIntScoreTwo <= 49)
                {
                    courseTotalPointsTwo = point2Two * unitIntScoreTwo;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", titleTwo, gradeDTwo, point2Two, courseTotalPointsTwo);
                    totalPointsTwo[i, 0] = courseTotalPointsTwo;

                }
                else if (testIntScoreTwo + examIntScoreTwo >= 40 && testIntScoreTwo + examIntScoreTwo < 44)
                {
                    courseTotalPointsTwo = point1Two * unitIntScoreTwo;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", titleTwo, gradeETwo, point1Two, courseTotalPointsTwo);
                    totalPointsTwo[i, 0] = courseTotalPointsTwo;

                }
                else if (testIntScoreTwo + examIntScoreTwo < 40)
                {
                    courseTotalPointsTwo = 0;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", titleTwo, gradeFTwo, point0Two, courseTotalPointsTwo);
                    totalPointsTwo[i, 0] = courseTotalPointsTwo;

                }

            }
            Console.WriteLine("\n\n");


            //Aggregate Score
            aggregateTwo = totalPointsTwo[0, 0];

            for (int i = 0; i < courseNumTwo - 1; i++)
            {
                aggregateTwo += totalPointsTwo[i + 1, 0];
            }

            int GPA = aggregateOne + aggregateTwo / courseNum + courseNumTwo;
            

            //Console.WriteLine("Aggregate Score For Semester One and Semester Two is : {1}", aggregateOne+aggregateTwo);
            Console.WriteLine("GPA for the session is : {0}", GPA);


        }
    }



    class Calcullator {
        public static void Main(string[] args)
        {
            Console.WriteLine("Student's CGPA/GPA Calculator");
            Console.WriteLine("Enter your semester \n 1) Semester One \n 2) Semester Two \n 3) Whole Session");
            int studentOption = Int32.Parse(Console.ReadLine());

            switch (studentOption)
            {
                case 1:
                    Console.WriteLine("Dear student, please enter your name:");
                    String name = Console.ReadLine();

                    new GPA("1");

                    break;
                case 2:
                    Console.WriteLine("Dear student, please enter your name:");
                    String nameTwo = Console.ReadLine();
                    new GPA("2");
                    break;
                case 3:
                    Console.WriteLine("Dear student, please enter your name:");
                    String nameThree = Console.ReadLine();
                    new Session();
                    break;
                default:
                    Console.WriteLine("Invalid Entry!");
                    break;
            }

            Console.ReadLine();
        }

    }


    
}
