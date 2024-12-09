namespace TechFielders
{
    public class User
    {

        /// <summary>
        /// The user identifier property
        /// </summary>
        private int _id;

        public int UserID
        {
            get { return _id; }
        }

        /// <summary>
        /// The users first name property
        /// </summary>
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        /// <summary>
        /// The users last name property
        /// </summary>
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        /// <summary>
        /// The users date of birth property
        /// </summary>
        private DateOnly _dob;

        public DateOnly DateOfBirth
        {
            get { return _dob; }
            set { _dob = value; }
        }

        /// <summary>
        /// The users email property
        /// </summary>
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        
        /// <summary>
        /// The users phone number property
        /// </summary>
        private string _phone;

        public string Phone 
        {
            get { return _phone; }
            set { _phone = value; }
        }

        /// <summary>
        /// The type of user property
        /// </summary>
        private UserType _type;

        public UserType Type
        {
            get { return _type; }
        }

        /// <summary>
        /// The users address property
        /// </summary>
        private Address _address;

        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// The users skills property
        /// </summary>
        private List<string> _skills;

        public List<string> Skills
        {
            get { return _skills; }
            set { _skills = value; }
        }

        /// <summary>
        /// Organisation property, used to get or set the organisation for this user. 
        /// </summary>
        private Organisation _organisation;

        public Organisation Organisation
        {
            get { return _organisation; }
            set { _organisation = value; }
        }

        /// <summary>
        /// Constructor for the user object
        /// </summary>
        /// <param name="id">The unique idetifier for the user</param>
        /// <param name="firstName">The users first nme</param>
        /// <param name="lastName">The users last name</param>
        /// /// <param name="dob">The users date of birth</param>
        /// <param name="email">The users email</param>
        /// <param name="phone">The users phone number</param>
        /// <param name="type">The type of user</param>
        public User(int id, string firstName, string lastName, DateOnly dob, string email, string phone, UserType type) 
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _dob = dob;
            _email = email;
            _phone = phone;
            _type = type;
        }
    }
}


