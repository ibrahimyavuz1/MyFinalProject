using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //Static: To not need to use "()"
    public static class Messages
    {
        public static string ProductAdded = "The product was added.";
        public static string ProductNameInvalid = "The product name is invalid!";
        public static string MaintenanceTime = "The system is under maintenance!";
        public static string ProductsListed="The product was listed.";
        public static string ProductCountOfCategoryError = "Each category can contain maximum 10 product!";
        public static string ProductUpdated = "The product was updated.";
        public static string ProductNameAlreadyExists = "The name has already existed!";
        public static string CategoryLimitExceeded = "The product can not be added because of category limit exceeded!";
    }
}
