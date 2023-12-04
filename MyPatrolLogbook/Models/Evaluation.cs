namespace MyPatrolLogbook.Models
{
    public class Evaluation
    {
        public int NumberOfScoutsCount { get; set; }

        public string HasPatrolJobs { get; set; }

        public string AttendancePercentage { get; set; }

        public int NumberOfPICsCount { get; set; }

        public string HasPatrolCorner { get; set; }

        public string PatrolLeaderAdvancementValid { get; set; }

        public string PatrolLeaderHasTraining { get; set; }

        public string AssistantPatrolLeaderAdvancementValid { get; set; }

        public string AssistantPatrolLeaderHasTraining { get; set; }

        public string PatrolMembersAdvancementValid { get; set; }

        public int NumberOfPatrolActivitiesCount { get; set; }

        public int NumberOfHikesCount { get; set; }

        public int NumberOfCampsCount { get; set; }

        public int NumberOfCommunityServiceProjectsHours { get; set; }

        public string NationalChallengePercentage { get; set; }
        public string StarPatrolAwardAchieved { get; set; }
    }
}
