using Codenation.Challenge;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "C:\\Users\\otavi\\codenation\\csharp-3\\Estados.txt";
            
            State[] states = new Program().StatesList(path);

            var linq = states.OrderByDescending(o => o.Area).Select(s => s.Name);

            foreach (string state in linq.Take(10))
            {
                Console.WriteLine(state);
            }
        }

        public State[] StatesList(string path)
        {
            string[] statesList = File.ReadAllLines(path);
            List<State> states = new List<State>();

            foreach (string state in statesList)
            {
                string[] stateInfo = state.Split(';');
                states.Add(new State(stateInfo[0], stateInfo[1], float.Parse(stateInfo[2])));
            }

            return states.ToArray();
        }
    }
}
