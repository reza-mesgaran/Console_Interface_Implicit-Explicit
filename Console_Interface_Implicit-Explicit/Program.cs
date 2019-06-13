using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 Note : 
 1) while we want to have a method in Interfaces with the same name ; we should use Explicit Implementation of Interface
 2) For using Explicit Implementation of Interface , we should create an instance from each Interface 
  */


namespace Console_Interface_Implicit_Explicit
{
    class Program 
    {

        static void Main(string[] args)
        {
            ClassNotifications c = new ClassNotifications();
            
            ISmsNotify smsNotify = c;
            smsNotify.Notify();

            IEmailNotify emailNotify = c;
            emailNotify.Notify();

            Console.ReadKey();

        }            
    }
}
interface ISmsNotify    // 1st Intertface
{
     void Notify();     

}
interface IEmailNotify // 2st Intertface
{
    void Notify();
}

class ClassNotifications :ISmsNotify,IEmailNotify      
{
    void ISmsNotify.Notify()
    {
        Console.WriteLine("This is a SMS Notification from 1th Interface");
    }

    void IEmailNotify.Notify()
    {
        Console.WriteLine("This is a EMAIL Notification from 2th Interface");
    }
}