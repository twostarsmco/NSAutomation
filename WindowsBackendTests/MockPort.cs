using System;
using System.Diagnostics;
using Command;
using Common;

namespace WindowsBackend.Tests
{
    internal class MockPort : IOutputPort
    {
        public void Send(OperateCommandBase command)
        {
            Debug.Print($"{DateTime.Now.ToString("hh:mm:ss.fff")}");
            foreach (var item in command.CommandBytes)
            {
                Debug.Print(item.ToString());
            }
        }
    }
}
