using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //Class Schedule array
        int[,] class_schedule = new int [5,6];
        //Jumbled array of class objects
        int[] jumbled_schedule = new int[30];
        //File path to the text file
        private static String filepath = "C:\\Users\\Michael\\Documents\\GCU-Projects\\ConsoleApplication1\\HW.txt";

        //Main methoed execution
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(filepath);
            //Loop to read in the text file
            while (reader.Peek() >= 0)
            {
                //if clause to exit

                //Create new object class for specific day/period combination
                Scheduled_Class class_object = new Scheduled_Class();
                class_object.class_name = reader.ReadLine();
                class_object.class_section = Convert.ToInt32(reader.ReadLine());
                class_object.class_size = Convert.ToInt32(reader.ReadLine());
                class_object.class_day = Convert.ToChar(reader.ReadLine());
                class_object.class_period = Convert.ToInt32(reader.ReadLine());

            }
            reader.Close();
        }
    }
    //Class object
    class Scheduled_Class
    {
        public String class_name;
        public int class_section;
        public int class_size;
        public char class_day;
        public int class_period;
    }
}
