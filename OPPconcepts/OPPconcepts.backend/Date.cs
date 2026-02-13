namespace OPPconcepts.backend
{
    public class Date
    {
        private int _day;
        private int _month;
        private int _year;

        public Date()
        {
            _year = 1900;
            _month = 1;
            _day = 1;
        }

        public Date(int year, int month, int day)
        {
            _day = day;
            _year = year;
            _month = month;
        }

        public int Year { 
            get => _year; 
            set => _year = ValidateYear(value); 
        }  
        public int Month { 
            get => _month; 
            set => _month = value; 
        }
        public int Day { 
            get => _day;
            set => _day = value;
        }   

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
        
        private int ValidateYear(int year)
        {
            if (year < 0 || year > 2100)
            {
                throw new ArgumentOutOfRangeException(nameof(year), "The year must be greater than 0");
            }
            return year;
        }


    }
   

}



