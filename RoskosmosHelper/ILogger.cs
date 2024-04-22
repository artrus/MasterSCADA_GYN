namespace RoskosmosHelper
{
    public interface ILogger
    {
        void WriteLine(string message);
        void WriteText(string message);
        void NewLine();
        void Clear();
    }
}
