using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Snakes_and_Ladders
{
    public static class Switch
    {
        public static bool flag = true; // flag for player 1 
        public static bool flag7 = true; // flag for player 2
        public static int counter1 = 1;
        public static int counter2 = 1;



        public static Point SwitchPoint1(int counter, Point p)
        {

            // Ladder Switch for Player 1
            switch (counter)
            {
                case 2:
                    counter1 = 38;
                    flag = false;
                    return new Point(298, 254);




                case 7:
                    counter1 = 14;
                    flag = false;
                    return new Point(439, 323);


                case 8:
                    counter1 = 31;
                    flag = false;
                    return new Point(544, 253);


                case 15:
                    counter1 = 26;
                    flag = true;
                    return new Point(403, 288);



                case 21:
                    counter1 = 42;
                    flag = true;
                    return new Point(260, 219);



                case 28:
                    counter1 = 84;
                    flag = true;
                    return new Point(331, 79);



                case 36:
                    counter1 = 44;
                    flag = true;
                    return new Point(332, 218);


                case 51:
                    counter1 = 67;
                    flag = true;
                    return new Point(437, 148);




                case 71:
                    counter1 = 91;
                    flag = false;
                    return new Point(543, 44);


                case 78:
                    counter1 = 98;
                    flag = false;
                    return new Point(300, 44);


                case 87:
                    counter1 = 94;
                    flag = false;
                    return new Point(438, 44);



                // End of Ladder Switch Cases
                // Snakes Switch for player 1


                case 16:
                    counter1 = 6;
                    flag = true;
                    return new Point(403, 364);


                case 46:
                    counter1 = 25;
                    flag = true;
                    return new Point(367, 288);


                case 49:
                    counter1 = 11;
                    flag = false;
                    return new Point(544, 325);


                case 62:
                    counter1 = 19;
                    flag = false;
                    return new Point(261, 323);


                case 64:
                    counter1 = 60;
                    flag = false;
                    return new Point(226, 182);


                case 74:
                    counter1 = 53;
                    flag = false;
                    return new Point(473, 182);


                case 92:
                    counter1 = 88;
                    flag = true;
                    return new Point(472, 80);


                case 95:
                    counter1 = 75;
                    flag = false;
                    return new Point(402, 113);


                case 99:
                    counter1 = 80;
                    flag = false;
                    return new Point(226, 113);

                // End of Snakes Switch Cases


                default:
                    return p;


            }


        }


        // Switch Method for player 2

        public static Point SwitchPoint2(int counter, Point p)
        {

            // Ladder Switch for Player 2
            switch (counter)
            {
                case 2:
                    counter2 = 38;
                    flag7 = false;
                    return new Point(298, 254);




                case 7:
                    counter2 = 14;
                    flag7 = false;
                    return new Point(439, 323);


                case 8:
                    counter2 = 31;
                    flag7 = false;
                    return new Point(544, 253);


                case 15:
                    counter2 = 26;
                    flag7 = true;
                    return new Point(403, 288);



                case 21:
                    counter2 = 42;
                    flag7 = true;
                    return new Point(260, 219);



                case 28:
                    counter2 = 84;
                    flag7 = true;
                    return new Point(331, 79);



                case 36:
                    counter2 = 44;
                    flag7 = true;
                    return new Point(332, 218);


                case 51:
                    counter2 = 67;
                    flag7 = true;
                    return new Point(437, 148);




                case 71:
                    counter2 = 91;
                    flag7 = false;
                    return new Point(543, 44);


                case 78:
                    counter2 = 98;
                    flag7 = false;
                    return new Point(300, 44);


                case 87:
                    counter2 = 94;
                    flag7 = false;
                    return new Point(438, 44);



                // End of Ladder Switch Cases
                // Snakes Switch for player 1


                case 16:
                    counter2 = 6;
                    flag7 = true;
                    return new Point(403, 364);


                case 46:
                    counter1 = 25;
                    flag = true;
                    return new Point(367, 288);


                case 49:
                    counter2 = 11;
                    flag7 = false;
                    return new Point(544, 325);


                case 62:
                    counter2 = 19;
                    flag7 = false;
                    return new Point(261, 323);


                case 64:
                    counter2 = 60;
                    flag7 = false;
                    return new Point(226, 182);


                case 74:
                    counter2 = 53;
                    flag7 = false;
                    return new Point(473, 182);


                case 92:
                    counter2 = 88;
                    flag7 = true;
                    return new Point(472, 80);


                case 95:
                    counter2 = 75;
                    flag7 = false;
                    return new Point(402, 113);


                case 99:
                    counter2 = 80;
                    flag7 = false;
                    return new Point(226, 113);

                // End of Snakes Switch Cases


                default:
                    return p;


            }


        }





    }
}
