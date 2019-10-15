using System;

namespace ReferenceTypeVsValueType
{
    class Program
    {
        static void Main(string[] args)
        {
        //    int x = 10;
        //    int y = x;
        //   // Display(x);   
        //    Change(y);
        //    display(y); // it uses the value y
                Player Archer = new Player();
                Archer.skillSets = 2;
                Archer.Xp = 10;

            Display(Archer);
            ChangePlayer(Archer);
            Display(Archer);
        }
        // public static void display(int n)
        // {
        //      System.Console.WriteLine(n);
        // }
        static void Display(Player player)
        {
              System.Console.WriteLine("Archer Now has "+ player.skillSets+ "skills");
              System.Console.WriteLine("Archer Now Has renewed xp of"+ player.Xp+" XP");
              System.Console.WriteLine("");
        }
        // static void Change (int valueToBeChanged)
        // {
        //     valueToBeChanged = 20;
        // }
        static void ChangePlayer(Player player)
        {
           player.skillSets = 4;
           player.Xp = 20;
        }

    }
    class Player
    {
        public int skillSets;
        public int Xp;
    }
}
