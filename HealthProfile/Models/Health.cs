using System;

namespace HealthProfile.Models
{
    public class Health
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int BirthYear { get; set; }
        public int CurrentYear { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public string FullName()
        {
            string fullname = FirstName + " " + LastName;
            return fullname;
        }
        public int Age()
        {
            int age = CurrentYear - BirthYear;
            return age;
        }

        public int MaximumHeartRate()
        {
            int maxHeartRate = 220 - (CurrentYear - BirthYear);
            return maxHeartRate;
        }

        public double MinimumTargetHeartRate()
        {
            double minTargetHeartRate = .5 * MaximumHeartRate();
            return minTargetHeartRate;
        }

        public double MaximumTargetHeartRate()
        {
            double maxTargetHeartRate = .85 * MaximumHeartRate();
            return maxTargetHeartRate;
        }

        public double BMI()
        {
            double weightHeight = (Weight * 703) / (Height * Height);
            double truncated = Math.Truncate(weightHeight * 100) / 100; 
            return truncated;
        }

    }
}
