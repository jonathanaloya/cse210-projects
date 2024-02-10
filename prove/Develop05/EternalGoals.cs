class EternalGoal : Goal
    {
        public int TimesToComplete { get; set; }
        public int TimesCompleted { get; set; }

        public EternalGoal(string name, string description, int timesToComplete) : base(name, description)
        {
            TimesToComplete = timesToComplete;
            TimesCompleted = 0;
        }
    }