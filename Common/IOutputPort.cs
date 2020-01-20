namespace Common
{
    public interface IOutputPort
    {
        void Send(Command.OperateCommandBase command);
    }
}
