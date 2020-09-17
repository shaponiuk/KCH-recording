using System;
using MainLogicLibrary;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var mLogic = new MainLogic();
            mLogic.showAudioDevices();
        }
    }
}
