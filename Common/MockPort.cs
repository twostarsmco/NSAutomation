using System;
using System.Diagnostics;
using Command;

namespace Common
{
    /// <summary>
    /// A mock of IOutputPort.
    /// </summary>
    public class MockPort : IOutputPort
    {
        /// <summary>
        /// This property has no effect on this class.
        /// </summary>
        public string PortName { get; set; }


        /// <summary>
        /// This method does nothing other than outputting debug informations.
        /// </summary>
        /// <param name="command">A command to perform</param>
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
