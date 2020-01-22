using System;
using System.Diagnostics;
using Command;

namespace Common
{
    public class MockPort : IOutputPort
    {
        public string PortName { get; set; }

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
