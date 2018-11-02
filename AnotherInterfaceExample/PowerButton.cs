using System;
namespace AnotherInterfaceExample
{
    public class PowerButton : ICommand
    {
        IElectronicDevice device;

        public PowerButton(IElectronicDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.On();        }

        public void Undo()
        {
            device.Off();       
        }
    }
}
