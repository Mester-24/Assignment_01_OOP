using Common;
namespace Session01OOP
{
    enum Grades
    {
        //Lables
        A, B, C, D, F
    }
    enum Gender
    {
        Male=1, Female=2,M=1,F=2
    }
    internal class Program
    {
      
     
        static void Main(string[] args)
        {
            #region What Is Access Modifers
            TypeA obj = new TypeA();
           // obj.X = 10;//Invalied
           // obj.Y = 10;//Invaled
            obj.Z = 30;
            #endregion
            #region Enum
            //Grades grade = Grades.A;
            //if(grade==Grades.A)
            //{
            //    Console.WriteLine("Congratulations A+");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry :(");
            //}
            #endregion
            #region Struct
            //Point P1 =new Point(8,16);
            //new Just For Constractor Selection
            //Declare For Object From Type "Point"
            //Clr Will Allocate 8 Bytes Unitialiized At Stack
            // Console.WriteLine(P1);

            #endregion
            #region What Is OOP

            #endregion
            #region Encapsulation
            Employee emp = new Employee(10,"Mohammed",40000);

            emp.Salary = 3000;//Set
            Console.WriteLine(emp.Salary);//Get

           // emp.SetName("Mester");
          //  Console.WriteLine(emp.GetName());


            //emp.Id = 50;//Set
            //Console.WriteLine(emp);//Get
            #endregion
            #region Indexer

            #endregion

        }
    }
}
