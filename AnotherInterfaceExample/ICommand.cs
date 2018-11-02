using System;
namespace AnotherInterfaceExample
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
