﻿namespace APSIM.Shared.Utilities
{
    using System.Threading;

    /// <summary>A simple runnable sleep job.</summary>
    public class JobRunnerSleepJob : IRunnable
    {
        // Duration of sleep in milliseconds.
        private int durationOfSleep;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="duration">Duration of sleep in milliseconds.</param>
        public JobRunnerSleepJob(int duration = 500)
        {
            durationOfSleep = duration;
        }

        /// <summary>Called to start the job. Can throw on error.</summary>
        /// <param name="cancelToken">Is cancellation pending?</param>
        public void Run(CancellationTokenSource cancelToken)
        {
            Thread.Sleep(durationOfSleep);
        }
    }
}
