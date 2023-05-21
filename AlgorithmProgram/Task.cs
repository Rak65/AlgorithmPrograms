using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class Task
    {
        public int Deadline { get; }
        public int Minutes { get; }

        public Task(int deadline, int minutes)
        {
            Deadline = deadline;
            Minutes = minutes;
        }
    }
}
