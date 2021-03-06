using System;

namespace Monitis.Prototype.Logic.PerfomanceCounter
{
    /// <summary>
    /// Class represents names of perfomance counters
    /// </summary>
    public static class CounterNames
    {
        /// <summary>
        /// \Processor(_Total)\% Processor Time counter
        /// </summary>
        public static String ProcessorTotalTime
        {
            get { return Resources.ProcessorTimeCounter; }
        }

        /// <summary>
        /// \Memory\Available Bytes counter
        /// </summary>
        public static String MemoryAvailableBytes
        {
            get { return Resources.MemoryAvailableBytes; }
        }

    }
}