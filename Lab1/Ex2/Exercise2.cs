using System;
namespace Lab1.Ex2
{
    /*----PART A----*/
    public class PositiveNumber
    {
        private long value;

        public long Value
        {
            get { return value; }
            set { this.value = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Value must be strictly positive."); }
        }
    }

    /*----PART B----*/
    public class CustomRange
    {
        private long _min;
        private long _max;

        public CustomRange()
        {
            _min = 0;
            _max = 100;
        }

        public long Min
        {
            get { return _min; }
            set { _min = value <= _max ? value : throw new ArgumentOutOfRangeException(nameof(Min), "Min must not be greater than Max."); }
        }

        public long Max
        {
            get { return _max; }
            set { _max = value >= _min ? value : throw new ArgumentOutOfRangeException(nameof(Max), "Max must not be less than Min."); }
        }
    }

}

