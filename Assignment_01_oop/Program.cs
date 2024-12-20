namespace Assignment_01_oop
{
    internal class Program
    {
        enum WeekDays
        {
            Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday
        }

        enum Season
        {
            Spring=1, Summer, Autumn, Winter
        }

        enum Permissions
        {
            None = 0,
            Read = 1 << 0,   // 1
            Write = 1 << 1,  // 2
            Delete = 1 << 2, // 4
            Execute = 1 << 3 // 8
        }
        enum Colors
        {
            Red=1, Green, Blue
        }
        static void Main(string[] args)
        {
            #region Question01
            /*1-	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
            Then, write a C# program that prints out all the days of the week using this enum.*/
            //WeekDays weekDays =  WeekDays.Saturday;

            //for (int i=0; i<=6;i++)
            //{
            //    Console.WriteLine($"The day in the Week :{weekDays}\n");
            //    weekDays +=1;
            //}
            #endregion
            #region Question02
            /*2.	Define a struct "Person" with properties "Name" and "Age". 
              Create an array of three "Person" objects and populate it with data. 
              Then, write a C# program to display the details of all the persons in the array.*/
            //Person[] person = new Person[3];
            //person[0] = new Person("Mohammed", 26);
            //person[1] = new Person("Eshag", 56);
            //person[2] = new Person("Wjdan", 20);

            //Console.WriteLine("Details of persons:");
            //for (int i = 0; i <= 3; i++)
            //{
            //    Console.WriteLine($"The Person Name is :{person[i].Name},The Age is :{person[i].Age}\n");
            //}


            #endregion
            #region Question03
            /*3.	Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)*/
            //Console.WriteLine("Select Your Season \n 1-Spring\n2-Summer\n3-Autumn\n4-Winter\n");
            //int season =Convert.ToInt32( Console.ReadLine());
            //switch (season)
            //{
            //    case 1:
            //        Console.WriteLine("spring march to may");
            //        break;
            //    case 2:
            //        Console.WriteLine("summer june to august");
            //        break;
            //    case 3:
            //        Console.WriteLine("Autumn September to November");
            //        break;
            //    case 4:
            //        Console.WriteLine("Winter Decmber to Febuary");
            //        break;
            //    default:
            //        Console.WriteLine("Error choice");
            //        break;
            //}
            #endregion
            #region Question04
            /*    4- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
             ●      Create Variable from previous Enum to Add and Remove Permission from variable, 
                    check if specific Permission is existed inside variable
             */

            //Permissions userPermissions = Permissions.None;

            //// Add permissions
            //userPermissions |= Permissions.Read;
            //userPermissions |= Permissions.Write;
            //Console.WriteLine($"Current Permissions: {userPermissions}");

            //// Check if a specific permission exists
            //if ((userPermissions & Permissions.Write) == Permissions.Write)
            //{
            //    Console.WriteLine("Write permission is granted.");
            //}
            //else
            //{
            //    Console.WriteLine("Write permission is not granted.");
            //}

            //// Remove  permission
            //userPermissions &= ~Permissions.Write;
            //Console.WriteLine($"Permissions after removing Write: {userPermissions}");

            //// Check again if the permission exists
            //if ((userPermissions & Permissions.Write) == Permissions.Write)
            //{
            //    Console.WriteLine("Write permission is granted.");
            //}
            //else
            //{
            //    Console.WriteLine("Write permission is not granted.");
            //}
            #endregion
            #region Question05
            /*5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
             Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.*/
            //Console.WriteLine("select Your Color\n1-Red\n2-Green\n3-Blue\n");
            //int selectColor=Convert.ToInt32(Console.ReadLine());
            //switch (selectColor)
            //{
            //    case 1:
            //        Console.WriteLine("color is a primary color");
            //        break;
            //    case 2:
            //        Console.WriteLine("color is a primary color");
            //        break;
            //    case 3:
            //        Console.WriteLine("color is a primary color");
            //        break;
            //    default:
            //        Console.WriteLine("color is Not a primary color");
            //        break;
            //}

            #endregion
            #region Question06
            /*6.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". 
                Write a C# program that takes two points as input from the user and calculates the distance between them.
             */
            //    Console.WriteLine("Enter coordinates for the first point (X Y):");
            //    string[] input1_point1 = Console.ReadLine().Split();
            //    Point point1 = new Point(double.Parse(input1_point1[0]), double.Parse(input1_point1[1]));


            //    Console.WriteLine("Enter coordinates for the second point (X Y):");
            //    string[] input2_point2 = Console.ReadLine().Split();
            //    Point point2 = new Point(double.Parse(input2_point2[0]), double.Parse(input2_point2[1]));

            //    double distance = CalculateDistanceOfPoint(point1, point2);

            //    Console.WriteLine($"The distance between the two points is: {distance:F2}");

            //static double CalculateDistanceOfPoint(Point p1, Point p2)
            //{
            //    double deltaX = p2.X - p1.X;
            //    double deltaY = p2.Y - p1.Y;
            //    return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            //}
            #endregion
            #region Question07
            /*7. Create a struct called "Person" with properties "Name" and "Age". 
             Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.*/

            Person[] person = new Person[3];
            person[0] = new Person("Mohammed", 26);
            person[1] = new Person("Eshag", 56);
            person[2] = new Person("Wjdan", 20);

            Console.WriteLine("Details of persons:");
            for (int i = 0; i <= person.Length; i++)
            {
                Console.WriteLine($"The Person Name is :{person[i].Name},The Age is :{person[i].Age}\n");
            }

            // Find the oldest person
            Person oldestPerson = person[0];
            foreach (var Person in person)
            {
                if (Person.Age > oldestPerson.Age)
                {
                    oldestPerson = Person;
                }
            }

            // Display the oldest persons details
            Console.WriteLine($"\nThe oldest person is {oldestPerson.Name} with age {oldestPerson.Age}.");

            #endregion
        }
    }
}
