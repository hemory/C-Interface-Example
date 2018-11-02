using System;
namespace AnotherInterfaceExample
{
    public class TVRemote
    {
       public static IElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
