namespace Command
{
    /// <summary>
    /// A command that halts the execution of following command 
    /// for specified duration of time.
    /// </summary>
    public class Wait : ICommand
    {
        /// <summary>
        /// The number of milliseconds to wait
        /// </summary>
        public int WaitTime { get; private set; }

        /// <summary>
        /// Initializes a new instance of class.
        /// </summary>
        /// <param name="waitTime">The number of milliseconds to wait</param>
        public Wait(int waitTime)
        {
            this.WaitTime = waitTime;
        }

        public override string ToString()
        {
            return $"Wait {this.WaitTime.ToString()}";
        }
    }
}
