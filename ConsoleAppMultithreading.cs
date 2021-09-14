using System;
using System.Threading;

namespace ConsoleAppMultithreading
{
    public class EmployeeThread
    {

        public static void ThreadMethode()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("number : " + i);
                Thread.Sleep(300);// stop the curent thread for x millisecondes

            }
        }

    }

    public class StudentThread
    {

        public void ThreadMethodeStudentNo()
        {
            Thread th = Thread.CurrentThread;
            Console.WriteLine("Student Thread name :" + th.Name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("student no : " + i);
                Thread.Sleep(3000);// stop the curent thread for x millisecondes

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {// using thread in networking server and clients apps and games 

            Thread th = Thread.CurrentThread;
            th.Name = "My Thread";
            Console.WriteLine("Thread name : " + th.Name);

            //------------------static void ThreadMethode------------------

            Thread th1 = new Thread(new ThreadStart(EmployeeThread.ThreadMethode));
            Thread th2 = new Thread(new ThreadStart(EmployeeThread.ThreadMethode));
            th1.Start();
            th2.Start();

            //-----------Threads of student class -------------------------
            // Threads object   public  void ThreadMethodeStudentNo
            StudentThread sth = new StudentThread();
            Thread th3 = new Thread(new ThreadStart(sth.ThreadMethodeStudentNo));
            Thread th4 = new Thread(new ThreadStart(sth.ThreadMethodeStudentNo));
            Thread th5 = new Thread(new ThreadStart(sth.ThreadMethodeStudentNo));

            //-------thread names-----------------------
            th3.Name = "Player 1";
            th4.Name = "Player 2";
            th5.Name = "Player 3";
            //--to---------thread priority------------------
            th3.Priority = ThreadPriority.Highest;
            th2.Priority = ThreadPriority.Lowest;
            th1.Priority = ThreadPriority.Normal;
            //---------------------------
            th3.Start();
            th3.Join();// other threads wait th3 to finich job to start other threads 
            th4.Start();
            th5.Start();
            //--------------------------------------------------------
            /*
              try
              {
                  th3.Abort();// stop this thread 
                  th4.Abort();
              }
              catch (ThreadAbortException e)
              {
                  Console.WriteLine( e.ToString());//System.PlatformNotSupportedException : 'Thread abort is not supported on this platform.'

              }
              Console.WriteLine("end of application");
  */
        }
    }
}
