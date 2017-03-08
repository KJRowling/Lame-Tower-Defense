using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);
            //map.width = 8;
            //map.height = 5;

            //Point point = new Point(4, 2);
            /*
            //bool isOnMap = map.OnMap(point);
            //Console.WriteLine(isOnMap);
            //point = new TowerDefense.Point(8, 5);
            //isOnMap = map.OnMap(point);
            //Console.WriteLine(isOnMap);
            */

            Point remotePoint = new Point(8, 3);
            //int pointDistance = point.DistanceTo(8, 3);
            Console.ReadLine();
            MapLocation pointX = new TowerDefense.MapLocation(4, 2, map);

            /*
            Point p = pointX;
            
            map.OnMap(new MapLocation(0, 0, map));
            Console.WriteLine(pointX.DistanceTo(5, 5));


            Console.WriteLine(pointX is MapLocation);
            Console.WriteLine(pointX is Point);

            Point point = new Point(0, 0);
            Console.WriteLine(point is MapLocation);
            */

            //throw exception if map location outside of map 
            try
            {


                //initilize path object with array of maplocation objects
                Path path = new Path(
                     new[] {

                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                 });

                
            Tower[] towers =
            {
                new Tower(new MapLocation(1, 3, map)),
                new Tower(new MapLocation(3, 3, map)),
                new Tower(new MapLocation(5, 3, map))
            };

            Invader[] invaders =
            {
                new TowerDefense.Invader(path),
                new TowerDefense.Invader(path),
                new TowerDefense.Invader(path),
                new TowerDefense.Invader(path)
            };
            //property initialization list
            Level level = new TowerDefense.Level(invaders)
            {
                Towers = towers
            };



                bool playerWon = level.Play();

                Console.WriteLine("Player " + (playerWon ? "won" : "lost"));


            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TowerDefenseException)
            {
                Console.WriteLine("Unhandled Tower Defense Exception");
            }
            //print my exception message
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception: " + ex);
            }


            //Invader invader = new TowerDefense.Invader();
            // MapLocation location = new MapLocation(0, 0, map);


            //invader.Location = location; // calls setter in invader location property.
            //location = invader.Location; //calls getter in invader location property.
            //return 
            //null check https://msdn.microsoft.com/en-us/library/dn986595.aspx
            //if (location != null)
            //{

            //    Console.WriteLine(location.x + "," + location.y);
            //}


            //do catch clauses from less to more specific

            //BASIC DRAWING MAYBE DO SOMETHING WITH THIS LATER
            Console.Clear();
            Console.Write("==========\n");
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                    Console.Write("@");
                else
                    Console.Write("=");

                for (int j = 0; j < 8; j++)
                {
                    if (i == 2)
                        Console.Write(">");
                    else
                        Console.Write("#");
                }
                if (i == 2)
                    Console.Write("$\n");
                else
                    Console.Write("=\n");
            }
            Console.Write("==========");
            Console.WriteLine();
            /*
            Console.Write("==========\n");
            for (int i = 0; i < 5; i++)
            {
                
                    Console.Write("=");

                for (int j = 0; j < 8; j++)
                {
                    if (i == 2 && j == 1)
                        Console.Write("@");
                    else if (i == 2)
                        Console.Write(">");
                    else
                        Console.Write("#");
                }
                if (i == 2)
                    Console.Write("$\n");
                else
                    Console.Write("=\n");
            }
            Console.Write("==========\n");
            Console.ReadLine();
            Console.Clear();
            

            while (true)
            { Console.WriteLine("||||||||||");
                Console.WriteLine("||||||||||");
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                    Console.WriteLine("//////////");
                Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\");
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                    Console.WriteLine("----------");
                Console.WriteLine("----------");
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                    Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\");
                Console.WriteLine("//////////");
                System.Threading.Thread.Sleep(500);
                Console.Clear();
            }
            

            Console.SetCursorPosition(2, 4);
            Console.WriteLine("@");
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(3, 4);
            Console.Write("@");
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(4, 4);
            Console.Write("@");
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(5, 4);
            Console.Write("@");
            System.Threading.Thread.Sleep(500);
            */

            //idea: each graphics line is an array
            //change the contents of the array based on what happens in the classes

            //
            /*
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 3);
            Console.WriteLine(">@>>>>>>>");
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(0, 3);
            Console.WriteLine(">>@>>>>>>");
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(0, 3);
            Console.WriteLine(">>>@>>>>>");
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(0, 3);
            Console.WriteLine(">>>>@>>>>");
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(0, 3);
            Console.WriteLine(">>>>>@>>>");
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(0, 3);
            Console.WriteLine(">>>>>>@>>");
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(0, 3);
            Console.WriteLine(">>>>>>>@>");
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(0, 3);
            Console.WriteLine(">>>>>>>>@");

            System.Threading.Thread.Sleep(500);
            */        
    Console.ReadLine();
        }
    }
}
