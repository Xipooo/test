using System;
using System.Threading;
using System.Threading.Tasks;

namespace test
{
    class EventSource
    {
        public event EventHandler<string> Timeout;

        public void StartTimeout(int milliseconds)
        {
            Task task = Task.Factory.StartNew(
                () =>
                {
                    Thread.Sleep(milliseconds);
                    Timeout(this, "Timeout complete!");
                });
        }
    }
}