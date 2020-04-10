using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern {
    public class TwitterClient {
        public List<Tweet> GetRecentTweets(string accessToken)
        {
            Console.WriteLine("Getting recent tweets!");
            return new List<Tweet>();
        }
    }
}
