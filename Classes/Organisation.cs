namespace TechFielders
{
    public class Organisation
    {
        private int _id;

        public int OrganisationID
        {
            get { return _id; }
        }

        private string _name;

        public string OrgName
        {
            get { return _name; }
            set { _name = value; }
        }

        private Address _address;

        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private User _owner;

        public User Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }

        public Organisation(int id)
        {
            _id = id;
        }
        
    }
}


