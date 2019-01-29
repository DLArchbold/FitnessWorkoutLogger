using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace CreateTable
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void CreateTable(SQLiteConnection AnyConnectionObject)
        {






            string Createsql = "DROP TABLE if exists Pushups";
            SQLiteCommand sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();
            //----------------------------------------------------------------------------------STRENGTH---------------------------------------------------------------------
            //-----------------------Strength->Bodyweight
            Createsql = "CREATE TABLE if not exists Pushups(PSUNum INTEGER PRIMARY KEY, Date DATE, Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();


            Createsql = "CREATE TABLE if not exists Pullups(PLUNum INTEGER PRIMARY KEY, Date DATE, Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists Situps(STUNum INTEGER PRIMARY KEY, Date DATE, Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();




            //--------------Strength->Equipment->barbell--------------------------------------------------------------
            Createsql = "CREATE TABLE if not exists BarbellBenchPress(BBPNum INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists BarbellBentOverRow(BORNum INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists BarbellDeadlift(BDLNum INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists BarbellBacksquat(BBSNum INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists BarbellOverheadPress(BOPNum INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists BarbellPowerClean(BPCNum INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();



            //Strength->equipment->dumbbell
            Createsql = "CREATE TABLE if not exists DumbbellSplitSquat(DBSSNum INTEGER PRIMARY KEY, Date DATE, FrontLeg VARCHAR(10), Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists DumbbellLateralRaise(DBLRNum INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists DumbbellBicepsCurl(DBBCNum INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists DumbbellLunge(DBLNum INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists DumbbellOverheadPress(DBOPNum INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists DumbbellChestFlye(DBCFNum INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists DumbbellBentOverRow(DBORNum INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists DumbbellChestPullOver(DBCPONum INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists DumbbellFrontSquat(DBFSNum INTEGER PRIMARY KEY, Date DATE, Weight DECIMAL(3,1), Repetitions DECIMAL(3,1), Sets INT)";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();



            //----------------------------------------------------------------------------Cardio----------------------------------------------------------------------------------
            //Cardio->Indoor->Elliptical trainer


            Createsql = "CREATE TABLE if not exists EllipticalCustom(EC INTEGER PRIMARY KEY, Date DATE, Resistance VARCHAR(20), RampControl VARCHAR(20), StepsPerMin DECIMAL(4, 1))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();




            Createsql = "CREATE TABLE if not exists EllipticalPreset(EP INTEGER PRIMARY KEY, Date DATE, Setting VARCHAR(20), Time VARCHAR(20), Distance VARCHAR(20))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();




            //Cardio->Indoor->Indoor bicycle

            Createsql = "CREATE TABLE if not exists IndoorBicycle(IB INTEGER PRIMARY KEY, Date DATE, Resistance VARCHAR(20), LengthOfTime VARCHAR(20), RevolutionsPerMinute DECIMAL(4,1))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            //Cardio->Indoor->Treadmill

            Createsql = "CREATE TABLE if not exists Treadmill(TMILL INTEGER PRIMARY KEY, Date DATE, Speed VARCHAR(20), Incline VARCHAR(20), Time VARCHAR(20))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();


            //Cardio->Outdoor

            Createsql = "CREATE TABLE if not exists Walking(WALK INTEGER PRIMARY KEY, Date DATE, Distance VARCHAR(20), Time VARCHAR(20))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists Cycling(CYC INTEGER PRIMARY KEY, Date DATE, Distance VARCHAR(20), Time VARCHAR(20))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();

            Createsql = "CREATE TABLE if not exists Running(RUN INTEGER PRIMARY KEY, Date DATE, Distance VARCHAR(20), Time VARCHAR(20))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();


            //Cardio->Other

            Createsql = "CREATE TABLE if not exists Swimming(SWIM INTEGER PRIMARY KEY, Date DATE, Laps DECIMAL(5,2), Time VARCHAR(20))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();


            Createsql = "CREATE TABLE if not exists JumpRope(JR INTEGER PRIMARY KEY, Date DATE, Revolutions Decimal(6, 2), Time VARCHAR(20), JumpType VARCHAR(20))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();



            //-------------------------------------------------------------------------------Balance--------------------------------------------------------------------------


            Createsql = "CREATE TABLE if not exists StandingOnOneFoot(SOOF INTEGER PRIMARY KEY, Date DATE, LegRaisedToFront VARCHAR(10), Time VARCHAR(20))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();


            Createsql = "CREATE TABLE if not exists HeelToToeWalk(HTTW INTEGER PRIMARY KEY, Date DATE, Time VARCHAR(20), Steps DECIMAL(6,2))";
            sqlite_cmd = new SQLiteCommand(Createsql, AnyConnectionObject);
            sqlite_cmd.ExecuteNonQuery();






            //SQLiteCommand VarQuery;
            ////// VarQuery = AnyConnectionObject.CreateCommand();
            //Createsql = "INSERT INTO Pushups values(1, datetime('now', 'localtime'), 3.5, 4)";
            //VarQuery = new SQLiteCommand(Createsql, AnyConnectionObject);
            //VarQuery.ExecuteNonQuery();




        }
    }
}
