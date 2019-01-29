
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using FitnessWorkoutLogger;

namespace FitnessAppFYPLAB
{
    class CreateFunction
    {

        public void CreateTable(SQLiteConnection AnyConnectionObject)
        {






            string Createsql = "DROP TABLE if exists Pushups";
            SQLiteCommand sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            //sqlite_cmd.ExecuteNonQuery();
            //----------------------------------------------------------------------------------STRENGTH---------------------------------------------------------------------
            //-----------------------Strength->Bodyweight
            Createsql = "CREATE TABLE if not exists Pushups(PK INTEGER PRIMARY KEY, Date DATE, Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();


            Createsql = "CREATE TABLE if not exists Pullups(PK INTEGER PRIMARY KEY, Date DATE, Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists Situps(PK INTEGER PRIMARY KEY, Date DATE, Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();




            //--------------Strength->Equipment->barbell--------------------------------------------------------------
            Createsql = "CREATE TABLE if not exists BarbellBenchPress(PK INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists BarbellBentOverRow(PK INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists BarbellDeadlift(PK INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists BarbellBacksquat(PK INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists BarbellOverheadPress(PK INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists BarbellPowerClean(PK INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();



            //Strength->equipment->dumbbell
            Createsql = "CREATE TABLE if not exists DumbbellSplitSquat(PK INTEGER PRIMARY KEY, Date DATE, FrontLeg VARCHAR(10), Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists DumbbellLateralRaise(PK INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists DumbbellBicepsCurl(PK INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists DumbbellLunge(PK INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists DumbbellOverheadPress(PK INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists DumbbellChestFlye(PK INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists DumbbellBentOverRow(PK INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists DumbbellChestPullOver(PK INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists DumbbellFrontSquat(PK INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();



            //----------------------------------------------------------------------------Cardio----------------------------------------------------------------------------------
            //Cardio->Indoor->Elliptical trainer


            Createsql = "CREATE TABLE if not exists EllipticalCustom(PK INTEGER PRIMARY KEY, Date DATE, Resistance VARCHAR(20), RampControl VARCHAR(20), StepsPerMin DECIMAL(4, 1))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();




            Createsql = "CREATE TABLE if not exists EllipticalPreset(PK INTEGER PRIMARY KEY, Date DATE, Setting VARCHAR(20), Time VARCHAR(20), Distance VARCHAR(20))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();




            //Cardio->Indoor->Indoor bicycle

            Createsql = "CREATE TABLE if not exists IndoorBicycle(PK INTEGER PRIMARY KEY, Date DATE, Resistance VARCHAR(20), LengthOfTime VARCHAR(20), RevolutionsPerMinute DECIMAL(4,1))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            //Cardio->Indoor->Treadmill

            Createsql = "CREATE TABLE if not exists Treadmill(PK INTEGER PRIMARY KEY, Date DATE, Speed VARCHAR(20), Incline VARCHAR(20), Time VARCHAR(20))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();


            //Cardio->Outdoor

            Createsql = "CREATE TABLE if not exists Walking(PK INTEGER PRIMARY KEY, Date DATE, Distance VARCHAR(20), Time VARCHAR(20))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists Cycling(PK INTEGER PRIMARY KEY, Date DATE, Distance VARCHAR(20), Time VARCHAR(20))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists Running(PK INTEGER PRIMARY KEY, Date DATE, Distance VARCHAR(20), Time VARCHAR(20))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();


            //Cardio->Other

            Createsql = "CREATE TABLE if not exists Swimming(PK INTEGER PRIMARY KEY, Date DATE, Laps DECIMAL(5,2), Time VARCHAR(20))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();


            Createsql = "CREATE TABLE if not exists JumpRope(PK INTEGER PRIMARY KEY, Date DATE, Revolutions Decimal(6, 2), Time VARCHAR(20), JumpType VARCHAR(20))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();



            //-------------------------------------------------------------------------------Balance--------------------------------------------------------------------------


            Createsql = "CREATE TABLE if not exists StandingOnOneFoot(PK INTEGER PRIMARY KEY, Date DATE, LegRaisedToFront VARCHAR(10), Time VARCHAR(20))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();


            Createsql = "CREATE TABLE if not exists HeelToToeWalk(PK INTEGER PRIMARY KEY, Date DATE, Time VARCHAR(20), Steps DECIMAL(6,2))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();









        }







    }
}