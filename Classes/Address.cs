namespace TechFielders 
{
    public class Address
    {

        private string _postCode;

        public string PostCode
        {
            get { return _postCode; }
            set { _postCode = value; }
        }

        private string _state;

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        private string _city;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }


        private string _street;

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        private string _number;

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        private int _unitNumber;

        public int UnitNumber
        {
            get { return _unitNumber; }
            set { _unitNumber = value; }
        }
        
    }
}


