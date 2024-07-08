using comman;
namespace ConsoleApp2

{

    #region enum
    public enum days
    {
        saturday, sunday, monday, tuesday, wednesday, thursday, friday
    }

    public enum garde
    { a, b, c }

    public enum gender
    {
        Male = 1, Female = 2
    }
    [Flags]
    public enum permision :byte

    {
        delete=1, excute=2, read=4, write=8
    }
    #endregion

    class employee
    {
     public   string name;
      public  int age;
     public   gender gender;
      public  permision permision;
    }
    internal class Program
    {
        #region handle_expetion
        static void dosomeprotectiveCode()
        {
            int x, y, z;
            bool flag;
            do
            {
                Console.WriteLine("enter a number ");
                flag = int.TryParse(Console.ReadLine(), out x);
            }
            while (!flag);

            do
            {
                Console.WriteLine("enter a number ");
                flag = int.TryParse(Console.ReadLine(), out y);
            }
            while (!flag || y == 0);

            z = x / y;

            int[] arr = { 1, 2, 3 };
            if (arr.Length > 10)
                arr[10] = 100;


        }

        #endregion

       

        

        static void Main()
        {
            #region expetion
            /*  try
              {
                  dosomeprotectiveCode();
                  //throw new Exception();
              }
              catch (Exception ex)
              {
                  Console.WriteLine(ex.Message);
              }
              finally
              {
                  Console.WriteLine("finally");
              }

              Console.WriteLine("after try");
          }*/
            #endregion

            #region acess modifier 
            /*     
                 typeA typea =new typeA(); //valied (public class )
                 typeb typeb = new typeb(); // invalid  ( internal class ) 
            */
            #endregion

            #region enum
            /*   days day = days.sunday;
               garde garde = garde.a; 
               ////////////////////
               if (garde == garde.a)
                   Console.WriteLine(":)");
               else
                   Console.WriteLine(":(");
               /////////////////////////////
               garde y = (garde)2; // c
               garde z = (garde)10; // 10
               ///////////////////////////////
               Console.WriteLine("enter a grade");
               Enum.TryParse(typeof(garde), Console.ReadLine(), out object x);
               Console.WriteLine($"your garde {x}");*/


            ///////////////////////////////////////////////////
            //ex3

           // string gender = "male";
          //    Enum.TryParse<gender>(gender, out gender result);
         // Enum.TryParse<gender>(gender,true , out gender result);  //genaric
        //   Console.WriteLine(result);
         
         employee employee = new employee();
            employee.age = 50;
            employee.permision = (permision)3;
            Console.WriteLine(employee.permision); // delete excute

            // to add use xor 
            employee.permision = employee.permision ^ permision.read;
           // delete excue read
            // to deny use xor again (if read exits will delet if not add )
            employee.permision = employee.permision ^ permision.read;
            Console.WriteLine(employee.permision);


            // if want add use or 
            employee.permision = employee.permision | permision.read;
            Console.WriteLine(employee.permision);



            #endregion



        }
    }
}
