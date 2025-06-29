using System;

namespace FourSeasonsLib
{
    public class SeasonService
    {
        public string GetSeason(string month)
        {
            month = month.ToLower();

            return month switch
            {
                "february" or "march" => "Spring",
                "april" or "may" or "june" => "Summer",
                "july" or "august" or "september" => "Monsoon",
                "october" or "november" => "Autumn",
                "december" or "january" => "Winter",
                _ => "Invalid"
            };
        }
    }
}
