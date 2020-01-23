namespace Common
{
    /// <summary>
    /// An interface that represents a port,
    /// to which byte data are sent in order to control a device.
    /// </summary>
    public interface IOutputPort
    {
        /// <summary>
        /// Send byte data of a given command
        /// </summary>
        /// <param name="command">A command to perform</param>
        void Send(Command.OperateCommandBase command);


        /// <summary>
        /// A string that identifies physical serial port.
        /// Syntax of this string may differ greatly depending on OS.
        /// </summary>
        string PortName { get; set; }
    }
}
