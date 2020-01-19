using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web.Mvc;
using Iceland2.Classes;
using Iceland2.Models;

namespace Iceland2.Controllers
{
    public class ValuesController : ApiController
    {
        // POST api/values
        //public String Post([FromBody]Models.InputItem Content)
        //{
        //    return Content.ItemName + Content.ItemQuality.ToString() + Content.ItemQuality.ToString();
        //}

        public List<Models.InputItem> Post([FromBody]List<Models.InputItem> JsonString)
        {
            SearchFunctions functions = new SearchFunctions();



            // Loop through all inputs
            for (var i = 0; i < JsonString.Count; i++)
            {
                // Begin check if value is valid
                if (functions.isValidItem(JsonString[i].ItemName))
                {
                    int QualityChangeVal;

                    QualityChangeVal = functions.GetAmendment(JsonString[i].ItemName, JsonString[i].ItemValue);

                    JsonString[i].ItemQuality = functions.SetQuality(JsonString[i].ItemQuality, QualityChangeVal);
                    
                    // Overwrite for SOAP, only item not to decrease in SellIn Value
                    if (JsonString[i].ItemName.ToLower() != "soap")
                    {
                        JsonString[i].ItemValue--;
                    }
                    
                } 
                else
                {
                    // Not a valid item, change item name to correspond to that
                    JsonString[i].ItemName = "Invalid Item";
                    JsonString[i].ItemQuality = 0;
                    JsonString[i].ItemValue = 0;
                }

            }

            return JsonString;

        }

        
    }
}
