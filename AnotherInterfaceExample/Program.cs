using System;

namespace AnotherInterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle buick = new Vehicle("Buick", 4, 160);  

            if (buick is IDrivable) // checks to see if it is IDriveable
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine("{0} cannot be driven", buick.Brand);
            }

            IElectronicDevice TV = TVRemote.GetDevice();
            PowerButton powBut = new PowerButton(TV);

            powBut.Execute();
            powBut.Undo();
        }
    }
}
