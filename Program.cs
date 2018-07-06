using System;


namespace URLGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            string project_name = " ";
            string activity_name = " ";

            try
            {
                Console.WriteLine("Enter the project name");
                project_name = Console.ReadLine();


                Console.WriteLine("Enter the activity name");
                activity_name = Console.ReadLine();


                string url = "https://companyserver.com/content/" + project_name + "/files/" + activity_name + "/" + activity_name + "Report.pdf";
                Console.WriteLine("\n");
                Console.WriteLine(url);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("PLease enter vaild details");
            }

        }
    }
}

