using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern {
    public class Oauth {
        public string RequestToken(string appKey, string appSecret)
        {
            Console.WriteLine("Get a request token");
            return "requestToken";
        }

        public string GetAccessToken(string appKey, string appSecret) {
            Console.WriteLine("Get an access token");
            return "accessToken";
        }
    }
}
