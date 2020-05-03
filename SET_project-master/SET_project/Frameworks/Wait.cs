﻿using System;
using System.Threading;

namespace SET_project.Frameworks
{
    public class Wait
    {
        public static bool WaitFor(Func<bool> func, int millisecondsTimeout = 3000, int waitInterval = 100)
        {
            DateTime start = DateTime.Now;
            do
            {
                if (func())
                    return true;
                Thread.Sleep(waitInterval);
            } while (DateTime.Now - start < TimeSpan.FromMilliseconds(millisecondsTimeout));

            return false;
        }
    }
}