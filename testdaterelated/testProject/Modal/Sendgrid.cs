using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testProject.Modal
{
    public class Sendgrid
    {

        public class Rootobject
        {
            public Personalization[] personalizations { get; set; }
        }

        public class Personalization
        {
            public To[] to { get; set; }
            public string subject { get; set; }
        }

        public class To
        {
            public string email { get; set; }
        }

    }
}