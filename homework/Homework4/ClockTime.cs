using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ClockTime
    {
    private int hour;
    private int minute;
    private int second;

        public int Hour { 
            get
            {
                return this.hour;
            } set
            {
                if(value <= 0 || value >12)
                {
                    throw new ArgumentException("invalid hour");
                } else
                {
                    this.hour = value;
                }
            }
        }

        public int Minute {
            get
            {
                return this.minute;
            }
            set
            {
                if(value <= 0 || value >60)
                {
                    throw new ArgumentException("invalid minute");
                } else
                {
                    this.minute = value;
                }
            }
        }
        public int Second
        {
            get
            {
                return this.second;
            }
            set
            {
                if(value <= 0 || value > 60)
                {
                    throw new ArgumentException("invalid second");
                } else
                {
                    this.second = value;
                }
            }
        }

        

    }

