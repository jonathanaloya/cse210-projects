 class ChecklistGoal : Goal
    {
        public int TimesToComplete { get; set; }
        public int TimesCompleted { get; set; }
        public int BonusPoints { get; set; }

        public ChecklistGoal(string name, string description, int timesToComplete, int bonusPoints) : base(name, description)
        {
            TimesToComplete = timesToComplete;
            TimesCompleted = 0;
            BonusPoints = bonusPoints;
        }
    }