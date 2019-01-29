using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

using FitnessWorkoutLogger;
using FitnessAppFYPLAB;

namespace FitnessAppFYPLAB
{
    class StrengthInsertRead
    {
     
        public static int ReadInt32(string value)
        {
            int val = -1;
            if (!int.TryParse(value, out val))
                return -1;
            return val;
        }



        public void InsertDataStrength(SQLiteConnection AnyConnectionObject, ref int Choice2, ref int Choice3, ref int Choice4)
        {
            FitnessWorkoutLogger.Program IntegerConverter = new Program();
            
            
            double Repetitions = 0;
            int Sets = 0;
            double Weight = 0;
            SQLiteCommand SQLQuery;
            string ChooseTable = null;


            Console.Write("******GUIDELINES*********:\n1) For (Decimal) labels, can only enter maximum of 99.9. Cannot enter decimal values with more than 1 decimal place; eg: 9.99.\n");
            Console.Write("2) For (int) labels, can only enter whole numbers. Decimal values eg: 4.3 are not allowed.\n");
            Console.Write("******END OF GUIDELINES***\n\n\n");
            if (Choice2 == 1)
            {



                Console.Write("Enter value for Repetitons (Decimal): ");
                Repetitions = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter value for Sets (int): ");
                Sets = ReadInt32(Console.ReadLine());


                
                SQLQuery = AnyConnectionObject.CreateCommand();



                if (Choice3 == 1)
                {
                    ChooseTable = "Pushups";

                }
                if (Choice3 == 2)
                {
                    ChooseTable = "Pullups";
                }
                if (Choice3 == 3)
                {
                    ChooseTable = "Situps";
                }



                SQLQuery.CommandText = "INSERT INTO " + ChooseTable + " (Date, Repetitions, Sets) VALUES(strftime('%d/%m/%Y %H:%M', 'now', 'localtime'), @param1, @param2)";
                SQLQuery.CommandType = System.Data.CommandType.Text;


                SQLQuery.Parameters.Add(new SQLiteParameter("@param1", Repetitions));
                SQLQuery.Parameters.Add(new SQLiteParameter("@param2", Sets));
                SQLQuery.ExecuteNonQuery();

            }



            //For Barbell (121 1-5)
            if (Choice2 == 2 && Choice3 == 1 && ((5 - Choice4) >= 0 && (5 - Choice4) <= 4))
            {

                Console.Write("Enter value for Weight (Decimal): ");
                Weight = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter value for Repetitions (Decimal): ");
                Repetitions = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter value for Sets (int): ");
                Sets = ReadInt32(Console.ReadLine());


                SQLQuery = AnyConnectionObject.CreateCommand();


                if (Choice4 == 1)
                {
                    ChooseTable = "BarbellBenchPress";

                }
                if (Choice4 == 2)
                {
                    ChooseTable = "BarbellBentOverRow";
                }
                if (Choice4 == 3)
                {
                    ChooseTable = "BarbellDeadlift";
                }

                if (Choice4 == 4)
                {
                    ChooseTable = "BarbellBackSquat";

                }
                if (Choice4 == 5)
                {
                    ChooseTable = "BarbellOverheadPress";
                }
                //(date('now', 'localtime'),

                SQLQuery.CommandText = "INSERT INTO " + ChooseTable + " (Date, Weight, Repetitions, Sets) VALUES(strftime('%d/%m/%Y %H:%M', 'now', 'localtime'), @param1, @param2, @param3)";
                SQLQuery.CommandType = System.Data.CommandType.Text;

                SQLQuery.Parameters.Add(new SQLiteParameter("@param1", Weight));
                SQLQuery.Parameters.Add(new SQLiteParameter("@param2", Repetitions));
                SQLQuery.Parameters.Add(new SQLiteParameter("@param3", Sets));
                SQLQuery.ExecuteNonQuery();



            }

            //For DumbBell(122 2-9)
            if (Choice2 == 2 && Choice3 == 2 && ((9 - Choice4) >= 0 && (9 - Choice4) <= 7))
            {

                Console.Write("Enter value for Weight (Decimal): ");
                Weight = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter value for Repetitions (Decimal): ");
                Repetitions = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter value for Sets (int): ");
                Sets = ReadInt32(Console.ReadLine());


                SQLQuery = AnyConnectionObject.CreateCommand();


                if (Choice4 == 2)
                {
                    ChooseTable = "DumbbellLateralRaise";

                }
                if (Choice4 == 3)
                {
                    ChooseTable = "DumbbellBicepsCurl";
                }
                if (Choice4 == 4)
                {
                    ChooseTable = "DumbbellLunge";
                }

                if (Choice4 == 5)
                {
                    ChooseTable = "DumbbellOverheadPress";

                }
                if (Choice4 == 6)
                {
                    ChooseTable = "DumbbellChestFlye";
                }

                if (Choice4 == 7)
                {
                    ChooseTable = "DumbbellBentOverRow";
                }
                if (Choice4 == 8)
                {
                    ChooseTable = "DumbbellChestPullOver";
                }
                if (Choice4 == 9)
                {
                    ChooseTable = "DumbbellFrontSquat";
                }



                SQLQuery.CommandText = "INSERT INTO " + ChooseTable + " (Date, Weight, Repetitions, Sets) VALUES(strftime('%d/%m/%Y %H:%M', 'now', 'localtime'), @param1, @param2, @param3)";
                SQLQuery.CommandType = System.Data.CommandType.Text;

                SQLQuery.Parameters.Add(new SQLiteParameter("@param1", Weight));
                SQLQuery.Parameters.Add(new SQLiteParameter("@param2", Repetitions));
                SQLQuery.Parameters.Add(new SQLiteParameter("@param3", Sets));
                SQLQuery.ExecuteNonQuery();



            }



            if (Choice2 == 2 && Choice3 == 1 && Choice4 == 6)
            {
                Console.Write("Enter value for Weight (Decimal): ");
                Weight = Convert.ToDouble(Console.ReadLine());



                Console.Write("Enter value for Repetitions (Decimal): ");
                Repetitions = Convert.ToDouble(Console.ReadLine());








                SQLQuery = AnyConnectionObject.CreateCommand();

                ChooseTable = "BarbellPowerClean";

                SQLQuery.CommandText = "INSERT INTO " + ChooseTable + " (Date, Weight, Repetitions) VALUES(strftime('%d/%m/%Y %H:%M', 'now', 'localtime'), @param1, @param2)";
                SQLQuery.CommandType = System.Data.CommandType.Text;

                SQLQuery.Parameters.Add(new SQLiteParameter("@param1", Weight));
                SQLQuery.Parameters.Add(new SQLiteParameter("@param2", Repetitions));
                SQLQuery.ExecuteNonQuery();




            }

            if (Choice2 == 2 && Choice3 == 2 && Choice4 == 1)
            {
                string FrontLeg = null;
                Console.Write("Enter the lunged leg (left/right): ");
                FrontLeg = Console.ReadLine();


                Console.Write("Enter value for Weight (Decimal): ");
                Weight = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter value for Repetitions (Decimal): ");
                Repetitions = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter value for Sets (int): ");
                Sets = ReadInt32(Console.ReadLine());


                ChooseTable = "DumbbellSplitSquat";

                SQLQuery = AnyConnectionObject.CreateCommand();

                SQLQuery.CommandText = "INSERT INTO " + ChooseTable + " (Date, FrontLeg, Weight, Repetitions, Sets) VALUES(strftime('%d/%m/%Y %H:%M', 'now', 'localtime'), @param1, @param2, @param3, @param4)";

                SQLQuery.CommandType = System.Data.CommandType.Text;
                SQLQuery.Parameters.Add(new SQLiteParameter("@param1", FrontLeg));
                SQLQuery.Parameters.Add(new SQLiteParameter("@param2", Weight));
                SQLQuery.Parameters.Add(new SQLiteParameter("@param3", Repetitions));
                SQLQuery.Parameters.Add(new SQLiteParameter("@param4", Sets));
                SQLQuery.ExecuteNonQuery();

            }





        }

     

        public void ReadDataStrength(SQLiteConnection AnyConnectionObject, ref string ChooseTable, ref int Choice2, ref int Choice3, ref int Choice4)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = AnyConnectionObject.CreateCommand();

            string IndexCol = null;



            if (Choice2 == 1)
            {

                if (Choice3 == 1)
                {
                    ChooseTable = "Pushups";
                    IndexCol = "PSUNum";
                }
                if (Choice3 == 2)
                {
                    ChooseTable = "Pullups";
                    IndexCol = "PLUNum";
                }
                if (Choice3 == 3)
                {
                    ChooseTable = "Situps";
                    IndexCol = "STUNum";
                }
            }





            //For Barbell (121 1-5)
            if (Choice2 == 2 && Choice3 == 1 && ((5 - Choice4) >= 0 && (5 - Choice4) <= 4))
            {


                if (Choice4 == 1)
                {
                    ChooseTable = "BarbellBenchPress";
                    IndexCol = "BBPNum";

                }
                if (Choice4 == 2)
                {
                    ChooseTable = "BarbellBentOverRow";
                    IndexCol = "BORNum";
                }
                if (Choice4 == 3)
                {
                    ChooseTable = "BarbellDeadlift";
                    IndexCol = "BDLNum";
                }

                if (Choice4 == 4)
                {
                    ChooseTable = "BarbellBackSquat";
                    IndexCol = "BBSNum";

                }
                if (Choice4 == 5)
                {
                    ChooseTable = "BarbellOverheadPress";
                    IndexCol = "BOPNum";
                }


            }

            //For DumbBell(122 2-9)
            if (Choice2 == 2 && Choice3 == 2 && ((9 - Choice4) >= 0 && (9 - Choice4) <= 7))
            {




                if (Choice4 == 2)
                {
                    ChooseTable = "DumbbellLateralRaise";
                    IndexCol = "DBLRNum";
                }
                if (Choice4 == 3)
                {
                    ChooseTable = "DumbbellBicepsCurl";
                    IndexCol = "DBBCNum";
                }
                if (Choice4 == 4)
                {
                    ChooseTable = "DumbbellLunge";
                    IndexCol = "DBLNum";
                }

                if (Choice4 == 5)
                {
                    ChooseTable = "DumbbellOverheadPress";
                    IndexCol = "DBOPNum";

                }
                if (Choice4 == 6)
                {
                    ChooseTable = "DumbbellChestFlye";
                    IndexCol = "DBCFNum";
                }

                if (Choice4 == 7)
                {
                    ChooseTable = "DumbbellBentOverRow";
                    IndexCol = "DBORNum";
                }
                if (Choice4 == 8)
                {
                    ChooseTable = "DumbbellChestPullOver";
                    IndexCol = "DBCPONum";
                }
                if (Choice4 == 9)
                {
                    ChooseTable = "DumbbellFrontSquat";
                    IndexCol = "DBFSNum";
                }





            }



            if (Choice2 == 2 && Choice3 == 1 && Choice4 == 6)
            {


                ChooseTable = "BarbellPowerClean";
                IndexCol = "BPCNum";




            }

            if (Choice2 == 2 && Choice3 == 2 && Choice4 == 1)
            {


                ChooseTable = "DumbbellSplitSquat";

                IndexCol = "BPCNum";

            }
















            sqlite_cmd.CommandText = "SELECT * FROM " + ChooseTable;

            sqlite_datareader = sqlite_cmd.ExecuteReader();


            double Weight = 0;
            string FrontLeg = null;


            //--------------------------------Table Columns---------------------//  
            if (Choice2 == 1 && ((3 - Choice3 >= 0) && (3 - Choice3 <= 2)))
            {
                Console.Write("  Date\t" + "    Time" + "      Index\t" + "Repetitions\t" + "Sets\n");
            }
            if (Choice2 == 2 && Choice3 == 1 && ((5 - Choice4) >= 0 && (5 - Choice4) <= 4))
            {
                Console.Write("  Date\t" + "    Time" + "     IndexColumn\t" + "Weight\t" + "Repetitions\t" + "Sets\n");
            }
            if (Choice2 == 2 && Choice3 == 2 && ((9 - Choice4) >= 0 && (9 - Choice4) <= 7))
            {
                Console.Write("  Date\t" + "    Time" + "     IndexColumn\t" + "Weight\t" + "Repetitions\t" + "Sets\n");
            }
            if (Choice2 == 2 && Choice3 == 1 && Choice4 == 6)
            {
                Console.Write("  Date\t" + "    Time" + "     IndexColumn\t" + "Weight\t" + "Repetitions\n");
            }

            if (Choice2 == 2 && Choice3 == 2 && Choice4 == 1)
            {
                Console.Write("  Date\t" + "    Time" + "     IndexColumn  " + "Front Leg\t" + "Weight\t" + "Repetitions\t" + "Sets\n");

            }
            //---------------------------------Table values------------------//

            while (sqlite_datareader.Read())
            {


                int UniqueNum = 0;
                UniqueNum = sqlite_datareader.GetInt32(0);
                string myreader = sqlite_datareader.GetString(1);



                if (Choice2 == 1 && ((3 - Choice3 >= 0) && (3 - Choice3 <= 2)))
                {

                    double mydouble = sqlite_datareader.GetDouble(2);
                    int mynumber = sqlite_datareader.GetInt32(3);

                    Console.Write("{0,0}{1,9}{2,11}{3,15}", myreader, UniqueNum, mydouble, mynumber + "\n");





                }



                if (Choice2 == 2 && Choice3 == 1 && ((5 - Choice4) >= 0 && (5 - Choice4) <= 4))
                {
                    Weight = sqlite_datareader.GetDouble(2);
                    double mydouble = sqlite_datareader.GetDouble(3);
                    int mynumber = sqlite_datareader.GetInt32(4);


                    Console.Write("{0,0}{1,11}{2,17}{3,13}{4,12}", myreader, UniqueNum, Weight, mydouble, mynumber + "\n");
                }


                if (Choice2 == 2 && Choice3 == 2 && ((9 - Choice4) >= 0 && (9 - Choice4) <= 7))
                {
                    Weight = sqlite_datareader.GetDouble(2);
                    double mydouble = sqlite_datareader.GetDouble(3);
                    int mynumber = sqlite_datareader.GetInt32(4);

                    Console.Write("{0,0}{1,9}{2,19}{3,10}{4,13}", myreader, UniqueNum, Weight, mydouble, mynumber + "\n");

                }



                if (Choice2 == 2 && Choice3 == 1 && Choice4 == 6)
                {
                    Weight = sqlite_datareader.GetDouble(2);
                    double mydouble = sqlite_datareader.GetDouble(3);

                    Console.Write("{0,0}{1,9}{2,18}{3,13}", myreader, UniqueNum, Weight, mydouble + "\n");



                }



                if (Choice2 == 2 && Choice3 == 2 && Choice4 == 1)
                {

                    FrontLeg = sqlite_datareader.GetString(2);
                    Weight = sqlite_datareader.GetDouble(3);
                    double mydouble = sqlite_datareader.GetDouble(4);
                    int mynumber = sqlite_datareader.GetInt32(5);
                    Console.Write("{0,0}{1,10}{2,17}{3,8}{4,10}{5,14}", myreader, UniqueNum, FrontLeg, Weight, mydouble, mynumber + "\n");



                }



            }




            //AnyConnectionObject.Close();
            Console.ReadKey();
        }


    }
}
