using System;
namespace PlexureApiTest.Model
{
    public class ResponseUser : Response
    {
        public ResponseUser()
        {
        }

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string AccessToken { get; set; }
    }
}
