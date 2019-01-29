using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using FitnessWorkoutLogger;

namespace FitnessAppFYPLAB
{
    class BalanceInsertRead
    {


        public void InsertDataBalance(SQLiteConnection AnyConnectionObject, ref int Choice2)
        {
            string Duration = null;
            string ChooseTable = null;


            SQLiteCommand SQLQuery;
            SQLQuery = AnyConnectionObject.CreateCommand();


            if (Choice2 == 1)
            {
                Console.Write("Enter the leg raised (left/right): ");
                string LegRaised = Console.ReadLine();
                Console.WriteLine("Enter the duration: ");
                Duration = Console.ReadLine();
                ChooseTable = "StandingOnOneFoot";


                SQLQuery.CommandText = "INSERT INTO " + ChooseTable + " (Date, LegRaisedToFront, Time) VALUES(strftime('%d/%m/%Y %H:%M', 'now', 'localtime'), @param1, @param2)";



                SQLQuery.Parameters.Add(new SQLiteParameter("@param1", LegRaised));
                SQLQuery.Parameters.Add(new SQLiteParameter("@param2", Duration));

                SQLQuery.ExecuteNonQuery();

            }
            if (Choice2 == 2)
            {
                Console.Write("*******GUIDELINES*******: For (Decimal), maximum number that can be entered is 9999.99. Max number of decimal places is 2, values like 9999.999 cannot be entered\n");
                Console.Write("*******END OF GUIDELINES**\n\n\n");

                Console.Write("Enter duration: ");
                Duration = Console.ReadLine();

                Console.Write("Enter the number of steps taken (Decimal): ");
                double StepsTaken = Convert.ToDouble(Console.ReadLine());
                ChooseTable = "HeelToToeWalk";



                SQLQuery.CommandText = "INSERT INTO " + ChooseTable + " (Date, Time, Steps) VALUES(strftime('%d/%m/%Y %H:%M', 'now', 'localtime'), @param1, @param2)";



                SQLQuery.Parameters.Add(new SQLiteParameter("@param1", Duration));
                SQLQuery.Parameters.Add(new SQLiteParameter("@param2", StepsTaken));

                SQLQuery.ExecuteNonQuery();

            }







        }




        public void ReadDataBalance(SQLiteConnection AnyConnectionObject, ref string ChooseTable, ref int Choice2, ref int Choice3, ref int Choice4)
        {


            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = AnyConnectionObject.CreateCommand();

            string IndexCol = null;




            if (Choice2 == 1)
            {
                ChooseTable = "StandingOnOneFoot";
                IndexCol = "SOOF";

            }
            if (Choice2 == 2)
            {
                ChooseTable = "HeelToToeWalk";
                IndexCol = "HTTW"; ;

            }


            sqlite_cmd.CommandText = "select * FROM " + ChooseTable;
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            String Date;
            int IndexColumn;
            if (Choice2 == 1)
            {
                Console.Write("   Date   " + " Time       " + "Index    " + "Leg Raised   " + "Duration\n");
            }
            if (Choice2 == 2)
            {
                Console.Write("   Date   " + " Time       " + "Index    " + "Duration  " + "Steps\n");
            }
            while (sqlite_datareader.Read())
            {
                IndexColumn = sqlite_datareader.GetInt32(0);
                Date = sqlite_datareader.GetString(1);
                string Duration;



                if (Choice2 == 1)
                {
                    string LegRaised = sqlite_datareader.GetString(2);
                    Duration = sqlite_datareader.GetString(3);
                    Console.Write("{0,0}{1,11}{2,12}{3,12}", Date, IndexColumn, LegRaised, Duration + "\n");

                }
                if (Choice2 == 2)
                {
                    Duration = sqlite_datareader.GetString(2);
                    double Steps = Convert.ToDouble(sqlite_datareader.GetDouble(3));
                    Console.Write("{0,0}{1,9}{2,11}{3,10}", Date, IndexColumn, Duration, Steps + "\n");

                }

            }


        }


    }
}
