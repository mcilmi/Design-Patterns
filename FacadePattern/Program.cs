using System;

namespace FacadePattern {
   public class Program {
       public static void Main(string[] args) {
            var twitterService = new TwitterService();
            twitterService.GetRecentTweets();
        }
    }
}
