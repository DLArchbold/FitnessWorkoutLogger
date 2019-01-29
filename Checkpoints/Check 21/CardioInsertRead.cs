using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace FitnessAppFYPLAB
{
    class CardioInsertRead
    {




        public void InsertDataCardio(SQLiteConnection AnyConnectionObject, ref int Choice2, ref int Choice3, ref int Choice4)
        {
            string Resistance = null;
            string ChooseTable = null;
            string Duration = null;
            string Distance = null;
            SQLiteCommand SQLQuery;

            SQLQuery = AnyConnectionObject.CreateCommand();
            SQLQuery.CommandType = System.Data.CommandType.Text;

            if (Choice2 == 1)
            {

                if (Choice4 == 1)
                {

                    Console.Write("*******GUIDELINES*******: For (Decimal), maximum number that can be entered is 999.9. Max number of decimal places is 1, values like 999.99 cannot be entered\n");
                    Console.Write("*******END OF GUIDELINES**\n\n\n");
                    Console.Write("Enter Resistance value: ");
                    Resistance = Console.ReadLine();
                    Console.Write("Enter Ramp Control : ");
                    string RampControl = Console.ReadLine();
                    Console.Write("Enter Steps Per Minute (Decimal): ");
                    double StepsPerMin = Convert.ToDouble(Console.ReadLine()); ;


                    ChooseTable = "EllipticalCustom";


                    SQLQuery.CommandText = "INSERT INTO " + ChooseTable + " (Date, Resistance, RampControl, StepsPerMin) VALUES(strftime('%d/%m/%Y %H:%M', 'now', 'localtime'), @param1, @param2, @param3)";



                    SQLQuery.Parameters.Add(new SQLiteParameter("@param1", Resistance));
                    SQLQuery.Parameters.Add(new SQLiteParameter("@param2", RampControl));
                    SQLQuery.Parameters.Add(new SQLiteParameter("@param3", StepsPerMin));
                    SQLQuery.ExecuteNonQuery();

                }

                if (Choice4 == 2)
                {
                    Console.Write("Enter Setting value: ");
                    string Setting = Console.ReadLine();
                    Console.Write("Enter Duration of setting: ");
                    Duration = Console.ReadLine();
                    Console.Write("Enter Distance: ");
                    double DblDistance = Convert.ToDouble(Console.ReadLine());

                    ChooseTable = "EllipticalPreset";

                    SQLQuery.CommandText = "INSERT INTO " + ChooseTable + " (Date, Setting, Time, Distance) VALUES(strftime('%d/%m/%Y %H:%M', 'now', 'localtime'), @param1, @param2, @param3)";



                    SQLQuery.Parameters.Add(new SQLiteParameter("@param1", Setting));
                    SQLQuery.Parameters.Add(new SQLiteParameter("@param2", Duration));
                    SQLQuery.Parameters.Add(new SQLiteParameter("@param3", DblDistance));
                    SQLQuery.ExecuteNonQuery();


                }


                if (Choice3 == 2)
                {

                    Console.Write("*******GUIDELINES*******: For (Decimal), maximum number that can be entered is 999.9. Max number of decimal places is 1, values like 999.99 cannot be entered\n");
                    Console.Write("*******END OF GUIDELINES**\n\n\n");

                    Console.Write("Enter Resistance: ");
                    Resistance = Console.ReadLine();
                    Console.Write("Enter Duration of setting: ");
                    Duration = Console.ReadLine();
                    Console.Write("Enter Revolutions Per Minute (RPM) (Decimal): ");
                    double RevolutionsPerMinute = Convert.ToDouble(Console.ReadLine());

                    ChooseTable = "IndoorBicycle";

                    SQLQuery.CommandText = "INSERT INTO " + ChooseTable + " (Date, Resistance, LengthOfTime, RevolutionsPerMinute) VALUES(strftime('%d/%m/%Y %H:%M', 'now', 'localtime'), @param1, @param2, @param3)";



                    SQLQuery.Parameters.Add(new SQLiteParameter("@param1", Resistance));
                    SQLQuery.Parameters.Add(new SQLiteParameter("@param2", Duration));
                    SQLQuery.Parameters.Add(new SQLiteParameter("@param3", RevolutionsPerMinute));
                    SQLQuery.ExecuteNonQuery();
                }

                if (Choice3 == 3)
                {
                    Console.Write("Enter Speed: ");
                    string Speed = Console.ReadLine();
                    Console.Write("Enter Incline: ");
                    string Incline = Console.ReadLine();
                    Console.Write("Enter Duration of setting: ");
                    Duration = Console.ReadLine();

                    ChooseTable = "Treadmill";

                    SQLQuery.CommandText = "INSERT INTO " + ChooseTable + " (Date, Speed, Incline, Time) VALUES(strftime('%d/%m/%Y %H:%M', 'now', 'localtime'), @param1, @param2, @param3)";



                    SQLQuery.Parameters.Add(new SQLiteParameter("@param1", Speed));
                    SQLQuery.Parameters.Add(new SQLiteParameter("@param2", Incline));
                    SQLQuery.Parameters.Add(new SQLiteParameter("@param3", Duration));
                    SQLQuery.ExecuteNonQuery();

                }



            }


            if (Choice2 == 2)
            {

                Console.Write("Enter distnace covered for workout: ");
                Distance = Console.ReadLine();


                Console.Write("Enter Duration of exercise: ");
                Duration = Console.ReadLine();

                if (Choice3 == 1)
                {
                    ChooseTable = "Walking";
                }
                if (Choice3 == 2)
                {
                    ChooseTable = "Cycling";
                }
                if (Choice3 == 3)
                {
                    ChooseTable = "Running";
                }


                SQLQuery.CommandText = "INSERT INTO " + ChooseTable + " (Date,  Distance, Time) VALUES(strftime('%d/%m/%Y %H:%M', 'now', 'localtime'), @param1, @param2)";



                SQLQuery.Parameters.Add(new SQLiteParameter("@param1", Distance));
                SQLQuery.Parameters.Add(new SQLiteParameter("@param2", Duration));
                SQLQuery.ExecuteNonQuery();


            }

            if (Choice2 == 3)
            {
                if (Choice3 == 1)
                {
                    double Laps = 0;

                    Console.Write("*******GUIDELINES*******: For (Decimal), maximum number that can be entered is 999.99. Max number of decimal places is 2, values like 999.999 cannot be entered\n");
                    Console.Write("*******END OF GUIDELINES**\n\n\n");



                    Console.Write("Enter the number of laps completed (Decimal): ");
                    Laps = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter duration of swim: ");
                    Duration = Console.ReadLine();
                    ChooseTable = "Swimming";
                    SQLQuery.CommandText = "INSERT INTO " + ChooseTable + " (Date,  Laps, Time) VALUES(strftime('%d/%m/%Y %H:%M', 'now', 'localtime'), @param1, @param2)";



                    SQLQuery.Parameters.Add(new SQLiteParameter("@param1", Laps));
                    SQLQuery.Parameters.Add(new SQLiteParameter("@param2", Duration));
                    SQLQuery.ExecuteNonQuery();
                }

                if (Choice3 == 2)
                {


                    Console.Write("*******GUIDELINES*******: For (Decimal), maximum number that can be entered is 9999.99. Max number of decimal places is 2, values like 9999.999 cannot be entered\n");
                    Console.Write("*******END OF GUIDELINES**\n\n\n");


                    Console.Write("Enter the number of successful jumps (Decimal): ");
                    double Revolutions = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter duration of workout: ");
                    Duration = Console.ReadLine();
                    Console.Write("Enter the type of jump: ");
                    string JumpType = Console.ReadLine();
                    ChooseTable = "JumpRope";

                    SQLQuery.CommandText = "INSERT INTO " + ChooseTable + " (Date,  Revolutions, Time, JumpType) VALUES(strftime('%d/%m/%Y %H:%M', 'now', 'localtime'), @param1, @param2, @param3)";



                    SQLQuery.Parameters.Add(new SQLiteParameter("@param1", Revolutions));
                    SQLQuery.Parameters.Add(new SQLiteParameter("@param2", Duration));
                    SQLQuery.Parameters.Add(new SQLiteParameter("@param3", JumpType));
                    SQLQuery.ExecuteNonQuery();
                }


            }




        }



        public void ReadDataCardio(SQLiteConnection AnyConnectionObject, ref string ChooseTable, ref int Choice2, ref int Choice3, ref int Choice4)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = AnyConnectionObject.CreateCommand();

            string IndexCol = null;



            if (Choice2 == 1)
            {

                if (Choice4 == 1)
                {

                    ChooseTable = "EllipticalCustom";
                    IndexCol = "EC";



                }

                if (Choice4 == 2)
                {


                    ChooseTable = "EllipticalPreset";
                    IndexCol = "EP";

                }


                if (Choice3 == 2)
                {

                    ChooseTable = "IndoorBicycle";
                    IndexCol = "IB";
                }

                if (Choice3 == 3)
                {
                    IndexCol = "IB";
                    ChooseTable = "Treadmill";


                }



            }


            if (Choice2 == 2)
            {



                if (Choice3 == 1)
                {
                    ChooseTable = "Walking";
                    IndexCol = "WALK";
                }
                else if (Choice3 == 2)
                {
                    IndexCol = "CYC";
                    ChooseTable = "Cycling";
                }
                else if (Choice3 == 3)
                {
                    ChooseTable = "Running";
                    IndexCol = "RUN";
                }




            }

            if (Choice2 == 3)
            {
                if (Choice3 == 1)
                {
                    IndexCol = "SWIM";
                    ChooseTable = "Swimming";
                }

                if (Choice3 == 2)
                {
                    IndexCol = "JR";
                    ChooseTable = "JumpRope";


                }
            }




            sqlite_cmd.CommandText = "SELECT * FROM " + ChooseTable;

            sqlite_datareader = sqlite_cmd.ExecuteReader();



            string Duration = null;
            string Resistance = null;
            string Distance = null;

            //------------------------------------------------------Table Columns------------------------------------------//




            if (Choice2 == 1)
            {

                if (Choice4 == 1)
                {

                    Console.Write("  Date\t" + "    Time" + "     Index\t" + "Resistance\t" + "Ramp Control\t" + "Steps/Min\n");



                }

                if (Choice4 == 2)
                {

                    Console.Write("  Date\t" + "    Time" + "     Index   " + "     Setting     \t" + "Duration\t" + "Distance\n");
                }


                if (Choice3 == 2)
                {
                    Console.Write("  Date\t" + "    Time" + "     Index\t" + "Resistance\t" + "Duration\t" + "Revolutions/Min\n");



                }

                if (Choice3 == 3)
                {

                    Console.Write("  Date\t" + "    Time" + "     Index\t" + "  Speed\t" + "   Incline\t   " + "Duration\n");

                }



            }

            if (Choice2 == 2)
            {




                Console.Write("  Date\t" + "    Time" + "     Index\t" + "Distance\t" + "Duration\n");


            }

            if (Choice2 == 3)
            {
                if (Choice3 == 1)
                {
                    Console.Write("  Date\t" + "    Time" + "     Index\t" + "Laps\t" + "Duration\n");
                }

                if (Choice3 == 2)
                {


                    Console.Write("  Date\t" + "    Time" + "     Index\t" + "Revolutions\t" + "Duration\t" + "Jump Type\n");
                }
            }



            //-----------------------------------------------------Table values---------------------------------------------------//




            while (sqlite_datareader.Read())
            {





                //Display values from column 1 (the date and time)

                int UniqueNum = 0;
                UniqueNum = sqlite_datareader.GetInt32(0);


                //Display values from column 1 (the date and time)

                string myreader = sqlite_datareader.GetString(1);







                if (Choice2 == 1)
                {

                    if (Choice4 == 1)
                    {


                        Resistance = sqlite_datareader.GetString(2);



                        string RampControl = sqlite_datareader.GetString(3);
                        double StepsPerMinute = sqlite_datareader.GetDouble(4);

                        Console.Write("{0,0}{1,9}{2,12}{3,16}{4,17}", myreader, UniqueNum, Resistance, RampControl, StepsPerMinute + "\n");








                    }

                    if (Choice4 == 2)
                    {


                        string Setting = sqlite_datareader.GetString(2);



                        Duration = sqlite_datareader.GetString(3);


                        //Distance here uses VARCHAR(20)
                        Distance = sqlite_datareader.GetString(4);



                        Console.Write("{0,0}{1,9}{2,16}{3,16}{4,17}", myreader, UniqueNum, Setting, Duration, Distance + "\n");


                    }


                    if (Choice3 == 2)//Indoor Bicycle
                    {


                        Resistance = sqlite_datareader.GetString(2);



                        Duration = sqlite_datareader.GetString(3);


                        double RevolutionsPerMinute = sqlite_datareader.GetDouble(4);

                        Console.Write("{0,0}{1,9}{2,12}{3,16}{4,17}", myreader, UniqueNum, Resistance, Duration, RevolutionsPerMinute + "\n");


                    }

                    if (Choice3 == 3)//Treadmill
                    {

                        string Speed = sqlite_datareader.GetString(2);



                        string Incline = sqlite_datareader.GetString(3);



                        Duration = sqlite_datareader.GetString(4);

                        Console.Write("{0,0}{1,9}{2,12}{3,13}{4,16}", myreader, UniqueNum, Speed, Incline, Duration + "\n");


                    }



                }


                if (Choice2 == 2)
                {
                    //Distance here uses VARCHAR(20)
                    Distance = sqlite_datareader.GetString(2);
                    Duration = sqlite_datareader.GetString(3);



                    Console.Write("{0,0}{1,9}{2,12}{3,17}", myreader, UniqueNum, Distance, Duration + "\n");



                }

                if (Choice2 == 3)
                {
                    if (Choice3 == 1)
                    {

                        double Laps = sqlite_datareader.GetDouble(2);



                        Duration = sqlite_datareader.GetString(3);

                        Console.Write("{0,0}{1,9}{2,10}{3,10}", myreader, UniqueNum, Laps, Duration + "\n");

                    }

                    if (Choice3 == 2)
                    {

                        double Revolutions = sqlite_datareader.GetDouble(2);



                        Duration = sqlite_datareader.GetString(3);



                        string JumpType = sqlite_datareader.GetString(4);



                        Console.Write("{0,0}{1,9}{2,13}{3,15}{4,22}", myreader, UniqueNum, Revolutions, Duration, JumpType + "\n");


                    }
                }



            }




            //AnyConnectionObject.Close();
            Console.ReadKey();


        }


    }
}
