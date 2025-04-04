﻿namespace cs_assignment3
{
    // Simple class used to read the commandline arguments.
    public class CLReader
    {
        private string[] _args { get; init; }

        public CLReader(string[] args)
        {
            _args = args;
        }

        // Using the out keyword, we can update the values of the variables passed to this method, outside of it.
        public void ReadArgs(out string inputFile) 
        {
            inputFile  = _args[0]; 
        }
    }
}
