namespace Codenation.Challenge
{
    public class StateArea : State
    {
        public StateArea(string name, string acronym, double area = 0) : base(name, acronym)
        {
            Name = name;
            Acronym = acronym;
            Area = area;
        }

        public new string Name { get; set; }

        public new string Acronym { get; set; }
        public double Area { get; set; }

    }

}
