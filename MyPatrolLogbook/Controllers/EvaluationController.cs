using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyPatrolLogbook.Models;
using MyPatrolLogbook.ViewModels;

namespace MyPatrolLogbook.Controllers
{
    public class EvaluationController : Controller
    {
        private readonly AppDBContext _appDBContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUserRepository applicationUserRepository;
        private readonly ICampRepository campRepository;
        private readonly IHikeRepository hikeRepository;
        private readonly ICommunityServiceRepository communityServiceRepository;
        private readonly IPatrolActivityRepository patrolActivityRepository;
        private readonly IPatrolInCouncilRepository patrolInCouncilRepository;
        private readonly IPatrolRepository patrolRepository;
        private readonly IRegisterRepository registerRepository;

        // Constructor
        public EvaluationController(IRegisterRepository registerRepository, IPatrolRepository patrolRepository, IPatrolInCouncilRepository patrolInCouncilRepository, IPatrolActivityRepository patrolActivityRepository, ICommunityServiceRepository communityServiceRepository, IHikeRepository hikeRepository, ICampRepository campRepository, AppDBContext appDBContext, UserManager<ApplicationUser> userManager, IApplicationUserRepository applicationUserRepository)
        {
            this.hikeRepository = hikeRepository;
            this.communityServiceRepository = communityServiceRepository;
            this.patrolActivityRepository = patrolActivityRepository;
            this.campRepository = campRepository;
            this.patrolInCouncilRepository = patrolInCouncilRepository;
            this.patrolRepository = patrolRepository;
            this.registerRepository = registerRepository;
            _appDBContext = appDBContext;
            _userManager = userManager;
            this.applicationUserRepository = applicationUserRepository;
        }

        [Authorize(Roles = "Scout")]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);

            int currentYearInt = DateTime.Now.Year;


            if (user.EmailConfirmed)
            {
                if (user.TroopId != null)
                {
                    if (user.PatrolId != null)
                    {
                        // Assign the Variables to the list view model
                        var evaluation = new Evaluation();

                        // Determine number of x for the year
                        var campListViewModel = new CampListViewModel();
                        campListViewModel.Camps = campRepository.GetAllCamps.Where(f => f.PatrolId == Int32.Parse(user.PatrolId) && (f.StartDateTime.Value.Year == currentYearInt) && (f.EndDateTime.Value.Year == currentYearInt));

                        int numCamps = 0;
                        numCamps += campListViewModel.Camps.Count();

                        var hikeListViewModel = new HikeListViewModel();
                        hikeListViewModel.Hikes = hikeRepository.GetAllHikes.Where(f => f.PatrolId == Int32.Parse(user.PatrolId) && (f.StartDateTime.Value.Year == currentYearInt) && (f.EndDateTime.Value.Year == currentYearInt));

                        int numHikes = 0;
                        numHikes += hikeListViewModel.Hikes.Count();

                        var commintyServiceListViewModel = new CommunityServiceListViewModel();
                        commintyServiceListViewModel.Projects = communityServiceRepository.GetAllProjects.Where(f => f.PatrolId == Int32.Parse(user.PatrolId) && (f.StartDateTime.Value.Year == currentYearInt) && (f.EndDateTime.Value.Year == currentYearInt));

                        int? totalHours = 0;
                        totalHours = commintyServiceListViewModel.Projects.Select(f => f.ProjectHours).ToList().Sum();

                        var patrolActivityListViewModel = new PatrolActivityListViewModel();
                        patrolActivityListViewModel.Activities = patrolActivityRepository.GetAllActivities.Where(f => f.PatrolId == Int32.Parse(user.PatrolId) && (f.StartDateTime.Value.Year == currentYearInt) && (f.EndDateTime.Value.Year == currentYearInt));

                        int numActivities = 0;
                        numActivities += patrolActivityListViewModel.Activities.Count();

                        var myPatrolInformationListViewModel = new MyPatrolInformationListViewModel();
                        myPatrolInformationListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId);

                        int numScouts = 0;
                        numScouts += myPatrolInformationListViewModel.MyScouts.Count();

                        var patrolInCouncilListViewModel = new PatrolInCouncilListViewModel();
                        patrolInCouncilListViewModel.PatrolInCouncils = patrolInCouncilRepository.GetAllPatrolInCouncils.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                        int numPICs = 0;
                        numPICs += patrolInCouncilListViewModel.PatrolInCouncils.Count();

                        var patrolListViewModel = new PatrolListViewModel();
                        patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                        bool hasPatrolCorner;
                        hasPatrolCorner = (bool)patrolListViewModel.Patrols.Select(f => f.HasPatrolCorner).FirstOrDefault();

                        var registerListViewModel = new RegisterListViewModel();
                        registerListViewModel.Registers = registerRepository.GetAllRegisters.Where(f => f.PatrolId == Int32.Parse(user.PatrolId) && (f.AttendanceDate.Value.Year == currentYearInt));

                        string totalAttendancePercentage = "";
                        double totalAttendancePercentageDbl = 0;
                        if (registerListViewModel.Registers.Count() > 0)
                        {
                            int totalNumberOfMeetings = 0;
                            totalNumberOfMeetings = registerListViewModel.Registers.Select(f => f.AttendanceDate).ToList().Count();

                            string totalAttendedStr = "";
                            foreach (var item in registerListViewModel.Registers.Select(f => f.MeetingAttendance).ToList())
                            {
                                totalAttendedStr += item;
                            }

                            int totalAttendedCount = 0;

                            for (int i = 0; i < totalAttendedStr.Length; i++)
                            {
                                if (totalAttendedStr[i] == ',')
                                {
                                    totalAttendedCount += 1;
                                }
                            }

                            // Determine the total attendance %:
                            // divide number of scouts that attended per evening by the total in patrol * 100 then divide by the number of meetings
                            
                            if(numScouts != 0)
                            {
                                totalAttendancePercentage = (((totalAttendedCount / numScouts) * 100) / totalNumberOfMeetings).ToString() + "%";
                                totalAttendancePercentageDbl = (((totalAttendedCount / numScouts) * 100) / totalNumberOfMeetings);

                            }
                            else
                            {
                                totalAttendancePercentage = "No Scouts added to this patrol!";

                            }

                        }
                        else
                        {
                            totalAttendancePercentage = "Please ensure registers are up to date!";
                        }

                        
                        // Determine if all scouts have patrol jobs
                        myPatrolInformationListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId);

                        for (int i = 0; i < numScouts; i++)
                        {
                            if (myPatrolInformationListViewModel.MyScouts.Select(c => c.PatrolJob).ElementAt(i) == "")
                            {
                                evaluation.HasPatrolJobs = "No";
                                break;
                            }
                            else
                            {
                                evaluation.HasPatrolJobs = "Yes";
                            }
                        }

                        // Determine if at least half of the scouts have the national challenge badge
                        myPatrolInformationListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId);
                        double percentageHasNationalChallenge = 0.0;
                        int numHasNationalChallengeCount = 0;
                        for (int i = 0; i < numScouts; i++)
                        {
                            if (myPatrolInformationListViewModel.MyScouts.Select(c => c.HasNationalChallenge).ElementAt(i) == true)
                            {
                                numHasNationalChallengeCount += 1;
                            }
                        }

                        // ISSUE WITH 1 = 0%
                        // number of scouts that have badge / by the number that do not * 100
                        if (numScouts != 0)
                        {
                            percentageHasNationalChallenge = (numHasNationalChallengeCount / numScouts) * 100;

                        }
                        else
                        {
                            totalAttendancePercentage = "No Scouts added to this patrol!";

                        }

                        // Determine if PL has Discoverer and 3 FC Theme or has FC
                        var myPatrolInformationPLListViewModel = new MyPatrolInformationListViewModel();
                        myPatrolInformationPLListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId && f.IsPatrolLeader == true);

                        if ((myPatrolInformationPLListViewModel.MyScouts.Select(c => c.NumFirstClassTheme).FirstOrDefault() == 6) || (myPatrolInformationPLListViewModel.MyScouts.Select(c => c.CurrentAdvancementAchieved).FirstOrDefault() == "First Class"))
                        {
                            evaluation.PatrolLeaderAdvancementValid = "Yes";
                        }
                        else
                        if ((myPatrolInformationPLListViewModel.MyScouts.Select(c => c.NumFirstClassTheme).FirstOrDefault() == 3) && ((myPatrolInformationPLListViewModel.MyScouts.Select(c => c.NumDiscovererTheme).FirstOrDefault() == 6)))
                        {
                            evaluation.PatrolLeaderAdvancementValid = "Yes";
                        }
                        else
                        {
                            evaluation.PatrolLeaderAdvancementValid = "No";
                        }

                        // Determine if APL has Traveller and 3 Discoverer Theme or has Discoverer
                        var myPatrolInformationAPLListViewModel = new MyPatrolInformationListViewModel();
                        myPatrolInformationAPLListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId && f.PatrolJob == "Assistant Patrol Leader");

                        if ((myPatrolInformationAPLListViewModel.MyScouts.Select(c => c.NumDiscovererTheme).FirstOrDefault() == 6) || (myPatrolInformationAPLListViewModel.MyScouts.Select(c => c.CurrentAdvancementAchieved).FirstOrDefault() == "Discoverer"))
                        {
                            evaluation.AssistantPatrolLeaderAdvancementValid = "Yes";
                        }
                        else
                        if ((myPatrolInformationAPLListViewModel.MyScouts.Select(c => c.NumDiscovererTheme).FirstOrDefault() == 3) && (myPatrolInformationAPLListViewModel.MyScouts.Select(c => c.NumTravellerTheme).FirstOrDefault() == 6))
                        {
                            evaluation.AssistantPatrolLeaderAdvancementValid = "Yes";
                        }
                        else
                        {
                            evaluation.AssistantPatrolLeaderAdvancementValid = "No";
                        }

                        // Determine if PL has attended a training course
                        var myPatrolInformationPLTrainingListViewModel = new MyPatrolInformationListViewModel();
                        myPatrolInformationPLTrainingListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId && f.IsPatrolLeader == true);

                        if (myPatrolInformationPLTrainingListViewModel.MyScouts.Select(c => c.HasAttendedTraining).FirstOrDefault() == true)
                        {
                            evaluation.PatrolLeaderHasTraining = "Yes";
                        }
                        else
                        {
                            evaluation.PatrolLeaderHasTraining = "No";
                        }

                        // Determine if APL has attended a training course
                        var myPatrolInformationAPLTrainingListViewModel = new MyPatrolInformationListViewModel();
                        myPatrolInformationAPLTrainingListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId && f.PatrolJob == "Assistant Patrol Leader");

                        if (myPatrolInformationAPLTrainingListViewModel.MyScouts.Select(c => c.HasAttendedTraining).FirstOrDefault() == true)
                        {
                            evaluation.AssistantPatrolLeaderHasTraining = "Yes";
                        }
                        else
                        {
                            evaluation.AssistantPatrolLeaderHasTraining = "No";
                        }

                        // Determine if Patrol Members 2 and 3 have 3 or more Traveller Theme
                        var myPatrolInformationPM3and4ListViewModel = new MyPatrolInformationListViewModel();
                        myPatrolInformationPM3and4ListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId && f.PatrolJob != "Assistant Patrol Leader" && f.IsPatrolLeader == false && (f.NumTravellerTheme >= 3 || f.CurrentAdvancementAchieved == "Traveller"));

                        if ((myPatrolInformationPM3and4ListViewModel.MyScouts.Count() >= 2))
                        {
                            evaluation.PatrolMembersAdvancementValid = "Yes";
                        }
                        else
                        {
                            evaluation.PatrolMembersAdvancementValid = "No";
                        }

                        evaluation.NumberOfScoutsCount = numScouts;
                        evaluation.NumberOfHikesCount = numHikes;
                        evaluation.NumberOfCampsCount = numCamps;
                        evaluation.NumberOfCommunityServiceProjectsHours = Int32.Parse(totalHours.ToString());
                        evaluation.NumberOfPatrolActivitiesCount = numActivities;
                        evaluation.NumberOfPICsCount = numPICs;
                        evaluation.AttendancePercentage = totalAttendancePercentage;
                        evaluation.NationalChallengePercentage = percentageHasNationalChallenge.ToString() + "%";

                        if (hasPatrolCorner)
                        {
                            evaluation.HasPatrolCorner = "Yes";
                        }
                        else
                        {
                            evaluation.HasPatrolCorner = "No";
                        }

                        // Now determine the Star Patrol Award Level Acheived
                        int awardAchievedCount = 0;

                        if (evaluation.NumberOfScoutsCount >= 6)
                        {
                            awardAchievedCount = awardAchievedCount + 1;
                        }

                        if (evaluation.HasPatrolJobs == "Yes")
                        {
                            awardAchievedCount = awardAchievedCount + 1;
                        }

                        if (totalAttendancePercentageDbl >= 65)
                        {
                            awardAchievedCount = awardAchievedCount + 1;
                        }

                        if (evaluation.NumberOfPICsCount >= 4)
                        {
                            awardAchievedCount = awardAchievedCount + 1;
                        }

                        if (evaluation.HasPatrolCorner == "Yes")
                        {
                            awardAchievedCount = awardAchievedCount + 1;
                        }

                        if (evaluation.PatrolLeaderAdvancementValid == "Yes")
                        {
                            awardAchievedCount = awardAchievedCount + 1;
                        }

                        if (evaluation.PatrolLeaderHasTraining == "Yes")
                        {
                            awardAchievedCount = awardAchievedCount + 1;
                        }

                        if (evaluation.AssistantPatrolLeaderAdvancementValid == "Yes")
                        {
                            awardAchievedCount = awardAchievedCount + 1;
                        }

                        if (evaluation.AssistantPatrolLeaderHasTraining == "Yes")
                        {
                            awardAchievedCount = awardAchievedCount + 1;
                        }

                        if (evaluation.PatrolMembersAdvancementValid == "Yes")
                        {
                            awardAchievedCount = awardAchievedCount + 1;
                        }

                        if (evaluation.NumberOfPatrolActivitiesCount >= 2)
                        {
                            awardAchievedCount = awardAchievedCount + 1;
                        }

                        if (evaluation.NumberOfHikesCount >= 1)
                        {
                            awardAchievedCount = awardAchievedCount + 1;
                        }

                        if (evaluation.NumberOfCampsCount >= 1)
                        {
                            awardAchievedCount = awardAchievedCount + 1;
                        }

                        if (evaluation.NumberOfCommunityServiceProjectsHours >= 25)
                        {
                            awardAchievedCount = awardAchievedCount + 1;
                        }

                        if (percentageHasNationalChallenge >= 50)
                        {
                            awardAchievedCount = awardAchievedCount + 1;
                        }

                        if(awardAchievedCount >= 13 && awardAchievedCount <= 15)
                        {
                            evaluation.StarPatrolAwardAchieved = "Gold";
                        }
                        else if (awardAchievedCount >= 9 && awardAchievedCount <= 12)
                        {
                            evaluation.StarPatrolAwardAchieved = "Silver";
                        }
                        else if (awardAchievedCount >= 5 && awardAchievedCount <= 8)
                        {
                            evaluation.StarPatrolAwardAchieved = "Bronze";
                        }
                        else
                        {
                            evaluation.StarPatrolAwardAchieved = "Participation";
                        }

                        return View(evaluation);

                    }
                    else
                    {
                        return RedirectToAction("TroopScouterMustConfirm", "MyPatrolInformation", new { area = "MyPatrolInformation" });
                    }

                }
                else
                {
                    return RedirectToAction("Assign", "Troop", new { area = "Troop" });
                }

            }
            else
            {
                return RedirectToAction("Confirm", "Role", new { area = "Role" });
            }
        }

        [Authorize(Roles = "TroopScouter")]
        public async Task<IActionResult> IndexTroopScouter()
        {
            var user = await _userManager.GetUserAsync(User);

            // Before allowing the Troop Scouter to further access the information on this page, their email needs to be verified
            if (user.EmailConfirmed)
            {
                // Before allowing the Troop Scouter to further access the information on this page, they need to have selected the Troop that they belong too
                if (user.TroopId != null)
                {
                    // This ensures that only users in the Troop Scouter Role are accessing the information
                    if (user.IsTroopScouter != null)
                    {

                        // The list of Patrols that belong to the Troop Scouter's Troop are populated in the dropdownlist
                        var viewPatrolListViewModel = new EvaluationListViewModel();
                    viewPatrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

                    var patrolList = viewPatrolListViewModel.Patrols.ToList();
                    SelectList list = new SelectList(patrolList, "PatrolId", "PatrolName");
                    ViewBag.patrolList = list;

                    return View(viewPatrolListViewModel);
                    }
                    // Otherwise redirect the user to the page stating that they must confirm their email!
                    else
                    {
                        return RedirectToAction("AdminMustConfirm", "CurrentScout", new { area = "CurrentScout" });

                    }

                }
                // Otherwise redirect the user to the page where they must select their troop!
                else
                {
                    return RedirectToAction("Assign", "Troop", new { area = "Troop" });
                }

            }
            // Otherwise redirect the user to the page where they must select their troop and province!
            else
            {
                return RedirectToAction("Confirm", "Role", new { area = "Role" });
            }
        }
        
        [HttpPost]
        public async Task<IActionResult> IndexTroopScouter(string FilterByPatrol)
        {
            var user = await _userManager.GetUserAsync(User);

            // The list of Patrols that belong to the Troop Scouter's Troop are populated in the dropdownlist
            var viewPatrolListViewModel = new PatrolListViewModel();
            viewPatrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

            var patrolList = viewPatrolListViewModel.Patrols.ToList();
            SelectList list = new SelectList(patrolList, "PatrolId", "PatrolName");
            ViewBag.patrolList = list;

            int currentYearInt = DateTime.Now.Year;

            // Get the value of the selected patrol from the dropdownlist
            FilterByPatrol = Request.Form["PatrolList"];

            // if the Troop Scouter does not filter the list of Scouts that belong to their troop, then all of the scouts within their troop are displayed to them 
            if (!string.IsNullOrEmpty(FilterByPatrol))
            {
                string patrolName = patrolRepository.GetAllPatrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrol)).Select(s => s.PatrolName).FirstOrDefault().ToString();

                ViewData["filterByPatrolEvaluation"] = "Selected Patrol: " + patrolName;
                // Get the PatroId of the selected Patrol
                // Assign the Variables to the list view model
                var evaluation = new EvaluationListViewModel();

                    // Determine number of x for the year
                    var campListViewModel = new CampListViewModel();
                    campListViewModel.Camps = campRepository.GetAllCamps.Where(f => f.PatrolId == Int32.Parse(FilterByPatrol) && (f.StartDateTime.Value.Year == currentYearInt) && (f.EndDateTime.Value.Year == currentYearInt));

                    int numCamps = 0;
                    numCamps += campListViewModel.Camps.Count();

                    var hikeListViewModel = new HikeListViewModel();
                    hikeListViewModel.Hikes = hikeRepository.GetAllHikes.Where(f => f.PatrolId == Int32.Parse(FilterByPatrol) && (f.StartDateTime.Value.Year == currentYearInt) && (f.EndDateTime.Value.Year == currentYearInt));

                    int numHikes = 0;
                    numHikes += hikeListViewModel.Hikes.Count();

                    var commintyServiceListViewModel = new CommunityServiceListViewModel();
                    commintyServiceListViewModel.Projects = communityServiceRepository.GetAllProjects.Where(f => f.PatrolId == Int32.Parse(FilterByPatrol) && (f.StartDateTime.Value.Year == currentYearInt) && (f.EndDateTime.Value.Year == currentYearInt));

                    int? totalHours = 0;
                    totalHours = commintyServiceListViewModel.Projects.Select(f => f.ProjectHours).ToList().Sum();

                    var patrolActivityListViewModel = new PatrolActivityListViewModel();
                    patrolActivityListViewModel.Activities = patrolActivityRepository.GetAllActivities.Where(f => f.PatrolId == Int32.Parse(FilterByPatrol) && (f.StartDateTime.Value.Year == currentYearInt) && (f.EndDateTime.Value.Year == currentYearInt));

                    int numActivities = 0;
                    numActivities += patrolActivityListViewModel.Activities.Count();

                    var myPatrolInformationListViewModel = new MyPatrolInformationListViewModel();
                    myPatrolInformationListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == FilterByPatrol);

                    int numScouts = 0;
                    numScouts += myPatrolInformationListViewModel.MyScouts.Count();

                    var patrolInCouncilListViewModel = new PatrolInCouncilListViewModel();
                    patrolInCouncilListViewModel.PatrolInCouncils = patrolInCouncilRepository.GetAllPatrolInCouncils.Where(f => f.PatrolId == Int32.Parse(FilterByPatrol));

                    int numPICs = 0;
                    numPICs += patrolInCouncilListViewModel.PatrolInCouncils.Count();

                    var patrolListViewModel = new PatrolListViewModel();
                    patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrol));

                    bool hasPatrolCorner;
                    hasPatrolCorner = (bool)patrolListViewModel.Patrols.Select(f => f.HasPatrolCorner).FirstOrDefault();

                    var registerListViewModel = new RegisterListViewModel();
                    registerListViewModel.Registers = registerRepository.GetAllRegisters.Where(f => f.PatrolId == Int32.Parse(FilterByPatrol) && (f.AttendanceDate.Value.Year == currentYearInt));

                    string totalAttendancePercentage = "";
                    double totalAttendancePercentageDbl = 0;
                    if (registerListViewModel.Registers.Count() > 0)
                    {
                        int totalNumberOfMeetings = 0;
                        totalNumberOfMeetings = registerListViewModel.Registers.Select(f => f.AttendanceDate).ToList().Count();

                        string totalAttendedStr = "";
                        foreach (var item in registerListViewModel.Registers.Select(f => f.MeetingAttendance).ToList())
                        {
                            totalAttendedStr += item;
                        }

                        int totalAttendedCount = 0;

                        for (int i = 0; i < totalAttendedStr.Length; i++)
                        {
                            if (totalAttendedStr[i] == ',')
                            {
                                totalAttendedCount += 1;
                            }
                        }

                    // Determine the total attendance %:
                    // divide number of scouts that attended per evening by the total in patrol * 100 then divide by the number of meetings

                    if (numScouts != 0)
                    {
                        totalAttendancePercentage = (((totalAttendedCount / numScouts) * 100) / totalNumberOfMeetings).ToString() + "%";
                        totalAttendancePercentageDbl = (((totalAttendedCount / numScouts) * 100) / totalNumberOfMeetings);

                    }
                    else
                    {
                        totalAttendancePercentage = "No Scouts added to this patrol!";

                    }

                }
                    else
                    {
                        totalAttendancePercentage = "Please ensure registers are up to date!";
                    }


                    // Determine if all scouts have patrol jobs
                    myPatrolInformationListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == FilterByPatrol);

                    for (int i = 0; i < numScouts; i++)
                    {
                        if (myPatrolInformationListViewModel.MyScouts.Select(c => c.PatrolJob).ElementAt(i) == "")
                        {
                            evaluation.HasPatrolJobs = "No";
                            break;
                        }
                        else
                        {
                            evaluation.HasPatrolJobs = "Yes";
                        }
                    }

                    // Determine if at least half of the scouts have the national challenge badge
                    myPatrolInformationListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == FilterByPatrol);
                    double percentageHasNationalChallenge = 0.0;
                    int numHasNationalChallengeCount = 0;
                    for (int i = 0; i < numScouts; i++)
                    {
                        if (myPatrolInformationListViewModel.MyScouts.Select(c => c.HasNationalChallenge).ElementAt(i) == true)
                        {
                            numHasNationalChallengeCount += 1;
                        }
                    }

                // ISSUE WITH 1 = 0%
                // number of scouts that have badge / by the number that do not * 100
                if (numScouts != 0)
                {
                    percentageHasNationalChallenge = (numHasNationalChallengeCount / numScouts) * 100;

                }
                else
                {
                    totalAttendancePercentage = "No Scouts added to this patrol!";

                }


                    // Determine if PL has Discoverer and 3 FC Theme or has FC
                    var myPatrolInformationPLListViewModel = new MyPatrolInformationListViewModel();
                    myPatrolInformationPLListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == FilterByPatrol && f.PatrolJob == "Patrol Leader");

                    if ((myPatrolInformationPLListViewModel.MyScouts.Select(c => c.NumFirstClassTheme).FirstOrDefault() == 6) || (myPatrolInformationPLListViewModel.MyScouts.Select(c => c.CurrentAdvancementAchieved).FirstOrDefault() == "First Class"))
                    {
                        evaluation.PatrolLeaderAdvancementValid = "Yes";
                    }
                    else
                    if ((myPatrolInformationPLListViewModel.MyScouts.Select(c => c.NumFirstClassTheme).FirstOrDefault() == 3) && ((myPatrolInformationPLListViewModel.MyScouts.Select(c => c.NumDiscovererTheme).FirstOrDefault() == 6)))
                    {
                        evaluation.PatrolLeaderAdvancementValid = "Yes";
                    }
                    else
                    {
                        evaluation.PatrolLeaderAdvancementValid = "No";
                    }

                    // Determine if APL has Traveller and 3 Discoverer Theme or has Discoverer
                    var myPatrolInformationAPLListViewModel = new MyPatrolInformationListViewModel();
                    myPatrolInformationAPLListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == FilterByPatrol && f.PatrolJob == "Assistant Patrol Leader");

                    if ((myPatrolInformationAPLListViewModel.MyScouts.Select(c => c.NumDiscovererTheme).FirstOrDefault() == 6) || (myPatrolInformationAPLListViewModel.MyScouts.Select(c => c.CurrentAdvancementAchieved).FirstOrDefault() == "Discoverer"))
                    {
                        evaluation.AssistantPatrolLeaderAdvancementValid = "Yes";
                    }
                    else
                    if ((myPatrolInformationAPLListViewModel.MyScouts.Select(c => c.NumDiscovererTheme).FirstOrDefault() == 3) && (myPatrolInformationAPLListViewModel.MyScouts.Select(c => c.NumTravellerTheme).FirstOrDefault() == 6))
                    {
                        evaluation.AssistantPatrolLeaderAdvancementValid = "Yes";
                    }
                    else
                    {
                        evaluation.AssistantPatrolLeaderAdvancementValid = "No";
                    }

                    // Determine if PL has attended a training course
                    var myPatrolInformationPLTrainingListViewModel = new MyPatrolInformationListViewModel();
                    myPatrolInformationPLTrainingListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == FilterByPatrol && f.IsPatrolLeader == true);

                    if (myPatrolInformationPLTrainingListViewModel.MyScouts.Select(c => c.HasAttendedTraining).FirstOrDefault() == true)
                    {
                        evaluation.PatrolLeaderHasTraining = "Yes";
                    }
                    else
                    {
                        evaluation.PatrolLeaderHasTraining = "No";
                    }

                    // Determine if APL has attended a training course
                    var myPatrolInformationAPLTrainingListViewModel = new MyPatrolInformationListViewModel();
                    myPatrolInformationAPLTrainingListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == FilterByPatrol && f.PatrolJob == "Assistant Patrol Leader");

                    if (myPatrolInformationAPLTrainingListViewModel.MyScouts.Select(c => c.HasAttendedTraining).FirstOrDefault() == true)
                    {
                        evaluation.AssistantPatrolLeaderHasTraining = "Yes";
                    }
                    else
                    {
                        evaluation.AssistantPatrolLeaderHasTraining = "No";
                    }

                    // Determine if Patrol Members 2 and 3 have 3 or more Traveller Theme
                    var myPatrolInformationPM3and4ListViewModel = new MyPatrolInformationListViewModel();
                    myPatrolInformationPM3and4ListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == FilterByPatrol && f.PatrolJob != "Assistant Patrol Leader" && f.IsPatrolLeader == false && (f.NumTravellerTheme >= 3 || f.CurrentAdvancementAchieved == "Traveller"));

                    if ((myPatrolInformationPM3and4ListViewModel.MyScouts.Count() >= 2))
                    {
                        evaluation.PatrolMembersAdvancementValid = "Yes";
                    }
                    else
                    {
                        evaluation.PatrolMembersAdvancementValid = "No";
                    }

                    evaluation.NumberOfScoutsCount = numScouts;
                    evaluation.NumberOfHikesCount = numHikes;
                    evaluation.NumberOfCampsCount = numCamps;
                    evaluation.NumberOfCommunityServiceProjectsHours = Int32.Parse(totalHours.ToString());
                    evaluation.NumberOfPatrolActivitiesCount = numActivities;
                    evaluation.NumberOfPICsCount = numPICs;
                    evaluation.AttendancePercentage = totalAttendancePercentage;
                    evaluation.NationalChallengePercentage = percentageHasNationalChallenge.ToString() + "%";

                    if ((bool)hasPatrolCorner)
                    {
                        evaluation.HasPatrolCorner = "Yes";
                    }
                    else
                    {
                        evaluation.HasPatrolCorner = "No";
                    }

                    // Now determine the Star Patrol Award Level Acheived
                    int awardAchievedCount = 0;

                    if (evaluation.NumberOfScoutsCount >= 6)
                    {
                        awardAchievedCount = awardAchievedCount + 1;
                    }

                    if (evaluation.HasPatrolJobs == "Yes")
                    {
                        awardAchievedCount = awardAchievedCount + 1;
                    }

                    if (totalAttendancePercentageDbl >= 65)
                    {
                        awardAchievedCount = awardAchievedCount + 1;
                    }

                    if (evaluation.NumberOfPICsCount >= 4)
                    {
                        awardAchievedCount = awardAchievedCount + 1;
                    }

                    if (evaluation.HasPatrolCorner == "Yes")
                    {
                        awardAchievedCount = awardAchievedCount + 1;
                    }

                    if (evaluation.PatrolLeaderAdvancementValid == "Yes")
                    {
                        awardAchievedCount = awardAchievedCount + 1;
                    }

                    if (evaluation.PatrolLeaderHasTraining == "Yes")
                    {
                        awardAchievedCount = awardAchievedCount + 1;
                    }

                    if (evaluation.AssistantPatrolLeaderAdvancementValid == "Yes")
                    {
                        awardAchievedCount = awardAchievedCount + 1;
                    }

                    if (evaluation.AssistantPatrolLeaderHasTraining == "Yes")
                    {
                        awardAchievedCount = awardAchievedCount + 1;
                    }

                    if (evaluation.PatrolMembersAdvancementValid == "Yes")
                    {
                        awardAchievedCount = awardAchievedCount + 1;
                    }

                    if (evaluation.NumberOfPatrolActivitiesCount >= 2)
                    {
                        awardAchievedCount = awardAchievedCount + 1;
                    }

                    if (evaluation.NumberOfHikesCount >= 1)
                    {
                        awardAchievedCount = awardAchievedCount + 1;
                    }

                    if (evaluation.NumberOfCampsCount >= 1)
                    {
                        awardAchievedCount = awardAchievedCount + 1;
                    }

                    if (evaluation.NumberOfCommunityServiceProjectsHours >= 25)
                    {
                        awardAchievedCount = awardAchievedCount + 1;
                    }

                    if (percentageHasNationalChallenge >= 50)
                    {
                        awardAchievedCount = awardAchievedCount + 1;
                    }

                    if (awardAchievedCount >= 13 && awardAchievedCount <= 15)
                    {
                        evaluation.StarPatrolAwardAchieved = "Gold";
                    }
                    else if (awardAchievedCount >= 9 && awardAchievedCount <= 12)
                    {
                        evaluation.StarPatrolAwardAchieved = "Silver";
                    }
                    else if (awardAchievedCount >= 5 && awardAchievedCount <= 8)
                    {
                        evaluation.StarPatrolAwardAchieved = "Bronze";
                    }
                    else
                    {
                        evaluation.StarPatrolAwardAchieved = "Participation";
                    }


                return View(evaluation);

            }
            else
            {
                ViewData["filterByPatrolEvaluation"] = "No Patrol Selected";
                return View();
            }
        }
    }
}
