
//https://www.codeguru.com/csharp/.net/net_data/using-sqlite-in-a-c-application.html
using FitnessAppFYPLAB;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace FitnessWorkoutLogger
{
    class Program
    {

        static void Main(string[] args)
        {
            string ActionType = null;
            string MenuControl = null;
            string ChooseTable = null;

            SQLiteConnection sqlite_conn_strength;
            SQLiteConnection sqlite_conn_cardio;
            SQLiteConnection sqlite_conn_balance;

            FitnessAppFYPLAB.CreateFunction SynthesizeTables = new CreateFunction();
            FitnessAppFYPLAB.StrengthInsertRead StrengthFunctions = new StrengthInsertRead();
            FitnessAppFYPLAB.CardioInsertRead CardioFunctions = new CardioInsertRead();
            FitnessAppFYPLAB.BalanceInsertRead BalanceFunctions = new BalanceInsertRead();
            //SynthesizeTables.CreateTable(sqlite_conn_balance);




            while (true)
            {



                sqlite_conn_strength = new SQLiteConnection("Data Source=StrengthDB.db; Version = 3; New = True; Compress = True; ");
                sqlite_conn_strength.Open();


                sqlite_conn_cardio = new SQLiteConnection("Data Source=CardioDB.db; Version = 3; New = True; Compress = True; ");
                sqlite_conn_cardio.Open();


                sqlite_conn_balance = new SQLiteConnection("Data Source=BalanceDB.db; Version = 3; New = True; Compress = True; ");
                sqlite_conn_balance.Open();


                int Choice1 = 0;
                int Choice2 = 0;
                int Choice3 = 0;
                int Choice4 = 0;

                do //Menu to ask actions user wants to do
                {


                    Console.Write("\n\n\n\n\n\n\n\nWhat do you want to do? Insert or see data related to a workout? Please enter words: INSERT or SEE or DELETE.");
                    ActionType = Console.ReadLine();
                    ActionType = ActionType.ToLower();
                } while (ActionType != "insert" && ActionType != "see" && ActionType != "delete");


                //Menu to determine which workout user wants to choose
                Menu(ref Choice1, ref Choice2, ref Choice3, ref Choice4);







                if (ActionType == "insert")
                {
                    InsertValues(StrengthFunctions, CardioFunctions, BalanceFunctions, SynthesizeTables, sqlite_conn_strength, sqlite_conn_cardio, sqlite_conn_balance, ref ChooseTable, ref Choice1, ref Choice2, ref Choice3, ref Choice4);
                }

                if (ActionType == "see")
                {
                    SeeFunction(StrengthFunctions, CardioFunctions, BalanceFunctions, SynthesizeTables, sqlite_conn_strength, sqlite_conn_cardio, sqlite_conn_balance, ref ChooseTable, ref Choice1, ref Choice2, ref Choice3, ref Choice4);
                }



                if (ActionType == "delete")
                {


                    DeleteFunction(StrengthFunctions, CardioFunctions, BalanceFunctions, SynthesizeTables, sqlite_conn_strength, sqlite_conn_cardio, sqlite_conn_balance, ref ChooseTable, ref Choice1, ref Choice2, ref Choice3, ref Choice4);



                }//end of delete





                do //Menu to ask whether user wants to continue
                {
                    Console.Write("\n\n\n\n\n\n\n\n\n\nDo you still want to continue (Enter YES or NO)?");

                    MenuControl = Console.ReadLine();
                    MenuControl = MenuControl.ToLower();
                } while (MenuControl != "yes" && MenuControl != "no");

                if (MenuControl == "no")
                {
                    break;
                }


                sqlite_conn_strength.Close();
                sqlite_conn_cardio.Close();
                sqlite_conn_balance.Close();

            }


        }


        static void InsertValues(FitnessAppFYPLAB.StrengthInsertRead StrengthFunctions, FitnessAppFYPLAB.CardioInsertRead CardioFunctions, FitnessAppFYPLAB.BalanceInsertRead BalanceFunctions, FitnessAppFYPLAB.CreateFunction SynthesizeTables, SQLiteConnection sqlite_conn_strength, SQLiteConnection sqlite_conn_cardio, SQLiteConnection sqlite_conn_balance, ref string ChooseTable, ref int Choice1, ref int Choice2, ref int Choice3, ref int Choice4)
        {
            if (Choice1 == 1)
            {


                SynthesizeTables.CreateTable(sqlite_conn_strength);




                StrengthFunctions.InsertDataStrength(sqlite_conn_strength, ref Choice2, ref Choice3, ref Choice4);





            }


            if (Choice1 == 2)
            {

              
                SynthesizeTables.CreateTable(sqlite_conn_cardio);



                CardioFunctions.InsertDataCardio(sqlite_conn_cardio, ref Choice2, ref Choice3, ref Choice4);




            }

            if (Choice1 == 3)
            {


                SynthesizeTables.CreateTable(sqlite_conn_balance);


                BalanceFunctions.InsertDataBalance(sqlite_conn_balance, ref Choice2);



            }
        }



        static void SeeFunction(FitnessAppFYPLAB.StrengthInsertRead StrengthFunctions, FitnessAppFYPLAB.CardioInsertRead CardioFunctions, FitnessAppFYPLAB.BalanceInsertRead BalanceFunctions, FitnessAppFYPLAB.CreateFunction SynthesizeTables, SQLiteConnection sqlite_conn_strength, SQLiteConnection sqlite_conn_cardio, SQLiteConnection sqlite_conn_balance, ref string ChooseTable, ref int Choice1, ref int Choice2, ref int Choice3, ref int Choice4)
        {
            if (Choice1 == 1)
            {






                SynthesizeTables.CreateTable(sqlite_conn_strength);

                StrengthFunctions.ReadDataStrength(sqlite_conn_strength, ref ChooseTable, ref Choice2, ref Choice3, ref Choice4);




            }


            if (Choice1 == 2)
            {





                SynthesizeTables.CreateTable(sqlite_conn_cardio);

                CardioFunctions.ReadDataCardio(sqlite_conn_cardio, ref ChooseTable, ref Choice2, ref Choice3, ref Choice4);



            }

            if (Choice1 == 3)
            {



                SynthesizeTables.CreateTable(sqlite_conn_balance);

                BalanceFunctions.ReadDataBalance(sqlite_conn_balance, ref ChooseTable, ref Choice2, ref Choice3, ref Choice4);


            }
        }

        static void DeleteFunction(FitnessAppFYPLAB.StrengthInsertRead StrengthFunctions, FitnessAppFYPLAB.CardioInsertRead CardioFunctions, FitnessAppFYPLAB.BalanceInsertRead BalanceFunctions, FitnessAppFYPLAB.CreateFunction SynthesizeTables, SQLiteConnection sqlite_conn_strength, SQLiteConnection sqlite_conn_cardio, SQLiteConnection sqlite_conn_balance, ref string ChooseTable, ref int Choice1, ref int Choice2, ref int Choice3, ref int Choice4)
        {
            SQLiteConnection ConnType = null;

            if (Choice1 == 1)
            {



                ConnType = sqlite_conn_strength;

                SynthesizeTables.CreateTable(sqlite_conn_strength);


                StrengthFunctions.ReadDataStrength(sqlite_conn_strength, ref ChooseTable, ref Choice2, ref Choice3, ref Choice4);




            }


            if (Choice1 == 2)
            {





                ConnType = sqlite_conn_cardio;
                SynthesizeTables.CreateTable(sqlite_conn_cardio);

                CardioFunctions.ReadDataCardio(sqlite_conn_cardio, ref ChooseTable, ref Choice2, ref Choice3, ref Choice4);



            }

            if (Choice1 == 3)
            {



                ConnType = sqlite_conn_balance;

                SynthesizeTables.CreateTable(sqlite_conn_balance);
                BalanceFunctions.ReadDataBalance(sqlite_conn_balance, ref ChooseTable, ref Choice2, ref Choice3, ref Choice4);


            }


            Console.Write("Please enter the number in the Index column to delete the workout: ");


            int ToDelete = ReadInt32(Console.ReadLine());
            string DeleteQuery = "DELETE FROM " + ChooseTable + " WHERE PK = " + ToDelete;


            SQLiteCommand DelQuery;
            DelQuery = ConnType.CreateCommand();
            DelQuery.CommandText = DeleteQuery;
            DelQuery.CommandType = System.Data.CommandType.Text;
            DelQuery.ExecuteNonQuery();
           



        }




        public static int ReadInt32(string value)
        {
            int val = -1;
            if (!int.TryParse(value, out val))
                return -1;
            return val;
        }











        static void L1andL2Prompt(ref int Choice1, ref int Choice2)
        {
            string FirstPrompt = "\n1) Strengh Workout\n2) Cardio Workout\n3) Balance Workout\n4) Favourites/Recent ";
            while (Choice1 == 0)
            {
                Console.WriteLine(FirstPrompt);
                Choice1 = ReadInt32(Console.ReadLine());


                switch (Choice1)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("1) Bodyweight Exercises\n2) Equipment Exercises");
                            Choice2 = ReadInt32(Console.ReadLine());
                        } while (Choice2 != 1 && Choice2 != 2);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("1) Indoor\n2) Outdoor\n3) Other");
                            Choice2 = ReadInt32(Console.ReadLine());
                        } while (Choice2 != 1 && Choice2 != 2 && Choice2 != 3);
                        break;
                    case 3:

                        do
                        {
                            Console.WriteLine("1) Standing on one foot\n2) Heel-to-toe walk");
                            Choice2 = ReadInt32(Console.ReadLine());
                        } while (Choice2 != 1 && Choice2 != 2);
                        break;
                    //case 4:
                    //    break;
                    default:
                        Choice1 = 0;
                        break;



                }
                Console.WriteLine(Choice1);


            }
        }

        static void L3andL4Prompt(ref int Choice1, ref int Choice2, ref int Choice3, ref int Choice4)
        {
            if (Choice1 == 1)
            {
                string BodyweightExercises = "1) Push-ups\n2) Pull-ups\n3) Sit-ups";
                string EquipmentTypeExercises = "1) Barbell\n2) Dumbbell";

                switch (Choice2)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine(BodyweightExercises);
                            Choice3 = ReadInt32(Console.ReadLine());
                            Choice4 = 0;
                        } while (Choice3 != 1 && Choice3 != 2 && Choice3 != 3);
                        break;
                    case 2:

                        do
                        {
                            Console.WriteLine(EquipmentTypeExercises);
                            Choice3 = ReadInt32(Console.ReadLine());
                        } while (Choice3 != 1 && Choice3 != 2);

                        string BarbellExercises = "1) Benchpress\n2) Bent-over-row\n3) Deadlift\n4) Backsquat\n5) Overhead press\n6) Powerclean\n";
                        string DumbbellExercises = "1) Split squat\n2) Lateral raise\n3) Biceps curl\n4) Lunge\n5) Overhead press\n6) Chest flye\n7) Bent-over-row\n8) Chest-pull-over\n9) Front squat\n";


                        if (Choice3 == 1)
                        {
                            do
                            {
                                Console.WriteLine(BarbellExercises);
                                Choice4 = ReadInt32(Console.ReadLine());
                            } while (((6 - Choice4) < 0) || ((6 - Choice4) > 5));
                        }

                        if (Choice3 == 2)
                        {
                            do
                            {
                                Console.WriteLine(DumbbellExercises);
                                Choice4 = ReadInt32(Console.ReadLine());
                            } while (((9 - Choice4) < 0) || ((9 - Choice4) > 8));

                        }

                        break;

                }





            }




            if (Choice1 == 2)
            {
                string IndoorExercises = "1) Elliptical trainer\n2) Indoor bicycle\n3) Treadmill";
                string OutdoorExercises = "1) Walking\n2) Cycling\n3) Running";
                string OtherExercises = "1) Swimming\n2) Jump rope";

                switch (Choice2)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine(IndoorExercises);
                            Choice3 = ReadInt32(Console.ReadLine());
                        } while (Choice3 != 1 && Choice3 != 2 && Choice3 != 3);

                        string EllipticalTrainerExercises = "1) Custom settings\n2) Preset";


                        if (Choice3 == 1)
                        {
                            do
                            {
                                Console.WriteLine(EllipticalTrainerExercises);
                                Choice4 = ReadInt32(Console.ReadLine());
                            } while (((2 - Choice4) < 0) || ((2 - Choice4) > 1));
                        }

                        break;

                    case 2:

                        do
                        {
                            Console.WriteLine(OutdoorExercises);
                            Choice3 = ReadInt32(Console.ReadLine());
                        } while (Choice3 != 1 && Choice3 != 2 && Choice3 != 3);


                        break;


                    case 3:
                        do
                        {
                            Console.WriteLine(OtherExercises);
                            Choice3 = ReadInt32(Console.ReadLine());
                        } while (Choice3 != 1 && Choice3 != 2);

                        break;
                }





            }
        }

        static void Menu(ref int Choice1, ref int Choice2, ref int Choice3, ref int Choice4)
        {
            Console.Write("\n\n\n\nPlease enter the numbers for the type of workout you want to interact with.\n\n\n\n\n");

            L1andL2Prompt(ref Choice1, ref Choice2);



            L3andL4Prompt(ref Choice1, ref Choice2, ref Choice3, ref Choice4);















        }



    }
}