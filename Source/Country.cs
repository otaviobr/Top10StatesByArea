using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Codenation.Challenge
{
    public class Country
    {
        private string path = "C:\\Users\\otavi\\codenation\\csharp-3\\Estados.txt";

        public State[] Top10StatesByArea()
        {
            return GetStateList(path).OrderByDescending(o => o.Area).Select(s => new State(s.Name, s.Acronym)).ToList().Take(10).ToArray();
        }

        public List<StateArea> GetStateList(string path)
        {
            string[] statesList = File.ReadAllLines(path);
            List<StateArea> states = new List<StateArea>();
            
            foreach (string state in statesList)
            {
                string[] stateInfo = state.Split(';');
                states.Add(new StateArea(stateInfo[0], stateInfo[1], float.Parse(stateInfo[2])));
            }

            return states;
        }
    }
}
