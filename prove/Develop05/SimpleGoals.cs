class SimpleGoal : Goal
    {
        public int Points { get; set; }

        public SimpleGoal(string name, string description, int points) : base(name, description)
        {
            Points = points;
        }
    }