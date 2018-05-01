using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Resturant.Data
{
    public class TsqlCrud
    {
        ResturantsEntities db = new ResturantsEntities();
        //Read All Resturants
        public IEnumerable<resturant_info> ShowResturants()
        {
            return db.resturant_info.ToList();
        }

        public IEnumerable<resturant_info> GetResturantInfo()
        {
            IEnumerable<resturant_info> result;
            using (var db = new ResturantsEntities())
            {
                var dataList = db.resturant_info.ToList();
                result = dataList.Select(x => DataToLibrary(x)).ToList();
            }

            return result;
        }

        public IEnumerable<resturant_info> SortingByName()
        {
            IEnumerable<resturant_info> result;
            IEnumerable<resturant_info> sortedList;
            using (var db = new ResturantsEntities())
            {
                var dataList = db.resturant_info.ToList();
                result = dataList.Select(x => DataToLibrary(x)).ToList();
                sortedList = result.OrderBy(x => x.rest_name);
            }

            return sortedList;
        }

        public IEnumerable<resturant_info> SortingByNameDesc()
        {
            IEnumerable<resturant_info> result;
            IEnumerable<resturant_info> sortedListDesc;
            using (var db = new ResturantsEntities())
            {
                var dataList = db.resturant_info.ToList();
                result = dataList.Select(x => DataToLibrary(x)).ToList();
                sortedListDesc = result.OrderByDescending(x => x.rest_name);
            }

            return sortedListDesc;
        }

        public IEnumerable<resturant_info> SortingByRating()
        {
            IEnumerable<resturant_info> result;
            IEnumerable<resturant_info> sortedListRating;
            using (var db = new ResturantsEntities())
            {
                var dataList = db.resturant_info.ToList();
                result = dataList.Select(x => DataToLibrary(x)).ToList();
                sortedListRating = result.OrderBy(x => x.rest_rating);
            }

            return sortedListRating;
        }

        //MAPPING
        public static resturant_info DataToLibrary(Data.resturant_info dataModel)
        {
            var libModel = new resturant_info()
            {
                rest_ID = dataModel.rest_ID,
                rest_name = dataModel.rest_name,
                rest_address = dataModel.rest_address,
                rest_zipcode = dataModel.rest_zipcode,
                rest_phoneNumber = dataModel.rest_phoneNumber,
                city = dataModel.city,
                state = dataModel.state,
                rest_rating = dataModel.rest_rating
            };
            return libModel;
        }

        public static Data.resturant_info LibraryToData(resturant_info libModel)
        {
            var dataModel = new Data.resturant_info()
            {
                rest_ID = libModel.rest_ID,
                rest_name = libModel.rest_name,
                rest_address = libModel.rest_address,
                rest_zipcode = libModel.rest_zipcode,
                rest_phoneNumber = libModel.rest_phoneNumber,
                city = libModel.city,
                state = libModel.state,
                rest_rating = libModel.rest_rating
            };
            return dataModel;
        }
        
    }
}