using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace delegateTest
{
    class DelegateTest
    {
        public delegate void run(string message);
        private run runClient;
        private string msg;
        private Thread thread;

        public DelegateTest(string msg, run runClient)
        {
            this.msg = msg;
            this.runClient = runClient;
            thread = new Thread(threadRun);
            thread.Name = msg;
        }

        private void threadRun()
        {
            runClient(msg);
        }

        public void start()
        {
            thread.Start();
        }
    }
}
