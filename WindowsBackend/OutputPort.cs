using System;
using System.IO.Ports;

using Common;
using Command;

namespace WindowsBackend
{
    /// <summary>
    /// A concrete implementation of IOutputPort for Windows, using System.IO.Ports.SerialPort.
    /// </summary>
    public class OutputPort : IOutputPort, IDisposable
    {
        private SerialPort port = new SerialPort();

        private object Locker = new object();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="comPortName">The name of COM port. This is passed to constructor of System.IO.Ports.SerialPort.</param>
        public OutputPort(string comPortName)
        {
            this.PortName = comPortName;
        }


        void IOutputPort.Send(OperateCommandBase command)
        {
            this.port.Write(command.CommandBytes, 0, command.CommandBytes.Length);
        }


        /// <summary>
        /// A string to identify COM port, e.g. "COM1".
        /// When new value is set, this instance Disposes of the current connection,
        /// and re-connect using the new value.
        /// </summary>
        public string PortName {
            get 
            {
                lock (this.Locker)
                {
                    return this.port.PortName;
                }
            }
            set 
            {
                lock (this.Locker)
                {
                    if (this.port.PortName != value)
                    {
                        this.port?.Dispose();
                        this.port = new SerialPort(value)
                        {
                            BaudRate = 115200,
                            Parity = Parity.None,
                            DataBits = 8,
                            StopBits = StopBits.One
                        };
                        this.port.Open();
                    }
                }
            }
        }


        #region IDisposable Support
        private bool disposedValue = false; // 重複する呼び出しを検出するには

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: マネージ状態を破棄します (マネージ オブジェクト)。
                    this.port.Dispose();
                }

                // TODO: アンマネージ リソース (アンマネージ オブジェクト) を解放し、下のファイナライザーをオーバーライドします。
                // TODO: 大きなフィールドを null に設定します。

                disposedValue = true;
            }
        }

        // TODO: 上の Dispose(bool disposing) にアンマネージ リソースを解放するコードが含まれる場合にのみ、ファイナライザーをオーバーライドします。
        // ~OutputPort()
        // {
        //   // このコードを変更しないでください。クリーンアップ コードを上の Dispose(bool disposing) に記述します。
        //   Dispose(false);
        // }

        // このコードは、破棄可能なパターンを正しく実装できるように追加されました。
        public void Dispose()
        {
            // このコードを変更しないでください。クリーンアップ コードを上の Dispose(bool disposing) に記述します。
            Dispose(true);
            // TODO: 上のファイナライザーがオーバーライドされる場合は、次の行のコメントを解除してください。
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
