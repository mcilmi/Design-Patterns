using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern {
   public class TwitterService : ITwitter{

       public void GetRecentTweets()
       {
           var oath = new Oauth();
           var requestToken = oath.RequestToken("appKey", "secret");
           var accessToken = oath.GetAccessToken("appKey", "secret");
           
           var twitterClient = new TwitterClient();
           var tweets = twitterClient.GetRecentTweets(accessToken);
       }
   }
}
