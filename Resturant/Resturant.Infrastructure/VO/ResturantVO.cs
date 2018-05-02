using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Resturant.Infrastructure.Common;

namespace Resturant.Infrastructure.VO
{
    public class ResturantVO
    {
        public string RestName { get; set; }
        public string RestAddress { get; set; }
        public int RestZipcode { get; set; }
        public string RestPhoneNumber { get; set; }
        public string RestCity { get; set; }
        public string RestState { get; set; }
        public double RestRating { get; set; }
        public List<string> Reviews= new List<string>();

        public ResturantVO(string restName, string restAddress, int restZipcode, string restPhoneNumber,
            string restCity, string restState, double restRating)
        {
            RestName = restName;
            RestAddress = restAddress;
            RestZipcode = restZipcode;
            RestPhoneNumber = restPhoneNumber;
            RestCity = restCity;
            RestState = restState;
            RestRating = restRating;
        }


    }
}
