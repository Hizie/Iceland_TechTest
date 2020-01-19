using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Iceland2.Classes
{
    public class SearchFunctions
    {
        /* 
         * Alters the Quality and checks that the Quality doesn't go above 0 or 50
         * 
         * Input : Int (14) Int (1)
         * Output : Int (15)
        */
        public int SetQuality(int Quality, int Amendment)
        {
            Quality = Quality + Amendment;

            // Begin limit checks

            if (Quality < 0) {
                // If below 0 then hard set back
                Quality = 0;
            } else if (Quality > 50) {
                // If over 50 then hard set back
                Quality = 50;
            }

            return Quality;
        }

        /*
         * Sets the required amendment value based on item type and SellIn value 
         * 
         * 
        */
        public int GetAmendment(String ItemName, int SellIn)
        {
            // Initialise and set default return value.
            int returnValue = 0;

            // Using lower case to allow for a non-case specific search
            switch (ItemName.ToLower())
            {
                case "aged brie":
                    if (SellIn > 0)
                    {
                        // Normal deduction
                        returnValue = 1;
                    } 
                    else
                    {
                        // Aged brie to increase in quality x2 if after SellIn < 0
                        returnValue = 2;
                    }
                    break;
                case "christmas crackers":
                    // Multiple levels of Sellin values to account for
                    if (SellIn < 0)
                    {
                        // Once value his 0 then use max possible quality as the amendment
                        returnValue = -50;
                    }
                    else if (SellIn < 5)
                    {
                        returnValue = 3;
                    }
                    else if (SellIn <= 10)
                    {
                        returnValue = 2;
                    }
                    else
                    {
                        // Taking anything over 10 day limit as increase normally.
                        returnValue = 1;
                    }

                    break;
                case "frozen item":
                    if (SellIn > 0)
                    {
                        returnValue = -1;
                    }
                    else
                    {
                        returnValue = -2;
                    }
                    break;
                case "fresh item":
                    if (SellIn > 0)
                    {
                        returnValue = -2;
                    }
                    else
                    {
                        returnValue = -4;
                    }
                    break;
                default:
                    // If nothing matches then no change
                    returnValue = 0;
                    break;
            }


            return returnValue;
        }

        // Function for isValid type
        public Boolean isValidItem(String ItemName)
        {
            Boolean returnValue = false;

            switch (ItemName.ToLower())
            {
                case "aged brie":
                    returnValue = true;
                    break;
                case "christmas crackers":
                    returnValue = true;
                    break;
                case "soap":
                    returnValue = true;
                    break;
                case "frozen item":
                    returnValue = true;
                    break;
                case "fresh item":
                    returnValue = true;
                    break;
                default:
                    returnValue = false;
                    break;
            }
            return returnValue;
        }
    }
}