namespace TechFielders
{
    public class DateRange
    {

        /// <summary>
        /// The start date and time for a job
        /// </summary>
        private DateTime _start;
        public DateTime Start
        {
            get { return _start; }
            set { _start = value; }
        }

        /// <summary>
        /// The end date and time for a job
        /// </summary>
        private DateTime _end;
        public DateTime End 
        {
            get { return _end; }
            set { _end = value; }
        }
        
    }    
}


