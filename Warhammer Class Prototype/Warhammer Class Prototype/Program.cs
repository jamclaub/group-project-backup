using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer_Class_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //string unitID;

            //Console.WriteLine("Please type a unit ID");

            //unitID = Console.ReadLine();

            unitManager userInfo;

            userInfo = new unitManager();

            //userInfo.addUnit(unitID);

            menuDriver(userInfo);
        }

       static void menuDriver(unitManager userInfo)
        {
            Console.WriteLine("Please enter a command");

            Console.WriteLine("1: Add a unit");
            Console.WriteLine("2: Remove a unit");
            Console.WriteLine("3: Print a unit");
            Console.WriteLine("4: Print list");
            Console.WriteLine("5: Quit");

            string userselect;

            userselect = Console.ReadLine();

            string n;

            while(userselect != "5")
            {
                if(userselect == "1")
                {
                    string unitID;

                    Console.WriteLine("Please type a unit ID");

                    unitID = Console.ReadLine();

                    userInfo.addUnit(unitID, unitName);

                    menuDriver(userInfo);

                }
                else if (userselect == "2")
                {

                    Console.WriteLine("Enter an index you wish to remove");
                    n = Console.ReadLine();

                    userInfo.removeUnit(n);

                    menuDriver(userInfo);
                }
                else if (userselect == "3")
                {
                    Console.WriteLine("Enter an index you wish to print");
                    n = Console.ReadLine();

                    userInfo.printUnit(n);

                    menuDriver(userInfo);

                }
                else if (userselect == "4")
                {
                    userInfo.printArmy();

                    menuDriver(userInfo);

                }

                


            }




        }

    }


    class unitManager
    {

        

        private List<unit> UserList;

        

        private int UnitCount;

        public unitManager()
        {

            //List<unit> temp = new List<unit>();
            UserList = new List<unit>();
        }
        public void addUnit(string UnitID, string unitName)
        {
            var Chars = UnitID.ToCharArray();

            //Console.WriteLine(Chars[1] + " " + Chars[2] + " " + Chars[3] + " " + Chars[7]);

            //Console.Read();

            if(Chars[1] == '1')
            {
                Console.WriteLine("Infantry!");

                if(Chars[7] == '1')
                {
                    Console.WriteLine("SingleLine!");

                    UserList.Add(new Infantry(unitName));

                    //UserList.Insert(UnitCount, new Infantry());
                    UnitCount++;
                }
                else if(Chars[7] == '2')
                {
                    //UserList.Add(new dualLine(new dualLine( new Infantry(unitName))));


                    //UserList.Insert(UnitCount, new dualLine(new Infantry()));

                    UnitCount++;
                }
            }

            else if(Chars[1] == '2')
            {
                UserList.Add(new Vehicle(unitName));

                Console.WriteLine("Vehicle");

                //UserList.Insert(UnitCount, new Vehicle());

                UnitCount++;
            }

            else if(Chars[1] == '3')
            {
                UserList.Add(new Walker(unitName));

                Console.WriteLine("Walker");

                //UserList.Insert(UnitCount, new Walker());

                UnitCount++;
            }
            /*
            for(int x = 0; x < UnitCount; x++)
            {
                Console.WriteLine("PrintLoop");
                UserList[x].print();
            }
            */

            //Console.Read();

        }

        public void printArmy()
        {

            for (int x = 0; x < UnitCount; x++)
            {
                Console.WriteLine("PrintArmy");
                UserList[x].print();
            }

        }

        public void printUnit(string listindex)
        {
            int x = Convert.ToInt32(listindex);
            
            Console.WriteLine("PrintUnit");
            UserList[x].print();
          
        }

        public void removeUnit(string listindex)
        {
            int x = Convert.ToInt32(listindex);
            UserList.RemoveAt(x);
            UnitCount--;
        }

   


    }

    abstract class unit
    {
        protected string name;

        protected string name2;

        protected string name3;

        protected int statline;

        protected int unitID;

        protected int unitIndex;

        public unit() {



        }
        
        public abstract void print();

        public abstract void ReadIn(string name, string statline, int unitID, int unitIndex);





    } 

    class Infantry : unit
    {
        public Infantry(string unitName):base()
        {
            name = unitName;
        }

        public override void print()
        {
            Console.WriteLine("Infantry!");
        }

        public override void ReadIn(string name, string statline, int unitID, int unitIndex)
        {

        }
    }

    class Vehicle : unit
    {

        public Vehicle(string unitName) : base()
        {
            name = unitName;
        }

        public override void print()
        {
            Console.WriteLine("Vehicle!");
        }

        public override void ReadIn(string name, string statline, int unitID, int unitIndex)
        {

        }
    }

    class Walker : unit
    {
        public Walker(string unitName) : base()
        {
            name = unitName;
        }

        public override void print()
        {
            Console.WriteLine("Walker!");
        }

        public override void ReadIn(string name, string statline, int unitID, int unitIndex)
        {

        }

    }
    /*
    class dualLine : Infantry
    {
        Infantry Store;
        /*
        public dualLine(Infantry user, string unitName) 
        {
            Store = user;
        }

        public override void print()
        {
            Store.print();
            Console.WriteLine("DualLineInfantry!");
        }

        public override void ReadIn(string name, string statline, int unitID, int unitIndex)
        {

        }
        
    }
    */
}
