using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Library.Models
{
    public class Resturant
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ZipCode { get; set; }
        public double AveRate { get; set; }
        public string Rating { get; set; }
        public string Review { get; set; }
        public List<double> RatingList = new List<double>();
        public List<string> ReviewList = new List<string>();

        public void Average()
        {
            double sum = 0;
            for (int i = 0; i < RatingList.Count; i++)
            {
                sum += RatingList[i];
            }
            AveRate = sum / RatingList.Count;
        }
        public double AddToRatings(double rate)
        {
            RatingList.Add(rate);
            return rate;
        }

        public string AddToReviews(string review)
        {
            ReviewList.Add(review);
            return review;
        }

        public void ReturnReviews()
        {
            foreach (string rev in ReviewList)
            {
                System.Console.WriteLine(rev + "\n");
            }
        }

        public double ReturnRate()
        {
            return AveRate;
        }

    }
}