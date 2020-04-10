using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern {
    public class Message
    {
        private string _content;

        public Message(string content)
        {
            this._content = content;
        }

        public string GetContent()
        {
            return this._content;
        }

    }
}
