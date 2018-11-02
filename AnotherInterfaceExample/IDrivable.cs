using System;
namespace AnotherInterfaceExample
{
    public interface IDrivable
    {
        int Wheels { get; set; }
        double Speed { get; set; } // All things drivable should have these properties based on this contract.

        void Move();
        void Stop(); // abstract methods
    }
}
