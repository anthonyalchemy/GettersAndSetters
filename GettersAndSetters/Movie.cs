using System;
using System.Collections.Generic;
using System.Text;

namespace GettersAndSetters
{
    class Movie
    {
        public string title;
        public string director;
        private string rating; // only code inside movie class can access this due to private

        public Movie (string aTitle, string aDirector, string aRating) // contructor 
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating
        {
            get { return rating; } // getter allows us to get rating attribute
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR") 
                {
                    rating = value;
                }
                else
                {
                    rating = "NR"; // set to not rating if not entered 
                }
            } //setter allows us to set the rating attribute 
        }


    }
}
