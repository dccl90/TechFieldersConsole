

namespace TechFielders
{
    public class Job
    {
        /// <summary>
        /// The job identifier
        /// </summary>
        private int _id;

        public int JobID
        {
            get { return _id; }
        }

        /// <summary>
        /// The job type
        /// </summary>
        private JobType _jobType;

        public JobType JobType
        {
            get { return _jobType; }
            set { _jobType = value; }
        }

        /// <summary>
        /// The user who owns the job
        /// </summary>
        private User _owner;

        public User Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }

        /// <summary>
        /// The user who has accepted the jo=b
        /// </summary>
        private User _assignee;
        
        public User Assignee
        {
            get { return _assignee; }
            set { _assignee = value; }
        }

        /// <summary>
        /// When the job is set to start and end
        /// </summary>
        private DateRange _duration;
        
        public DateRange Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        /// <summary>
        /// The skills required for the job
        /// </summary>
        private List<string> _requiredSkills;
        
        public List<string> RequiredSkills
        {
            get { return _requiredSkills; }
            set { _requiredSkills = value; }
        }

        //Constructor for the job
        public Job(int id)
        {
            _id = id;
        }
        
    }
}