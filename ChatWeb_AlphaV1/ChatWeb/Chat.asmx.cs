using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;

namespace ChatWeb
{
    /// <summary>
    /// Summary description for Chat1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [ScriptService]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Chat1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<String> PegaListaDeContatos(string username, string password)
        {
            List<String> a = new List<String>();
            a.Add("teste");
            a.Add("teste2");
            a.Add("teste3");
            return a;
        }


        [WebMethod]
        public bool IsContatoOnline(string username, string password,string usernameRequested)
        {
            return false;
        }

        [WebMethod]
        public bool SendMessage(string username, string password, string destinationUser, string message)
        {

            return false;
        }
        
        public struct MessagePacket
	    {
            public int id; //retirada do campo id da tabela Messages
	        public string username;
	        public string message;
    	}

        [WebMethod]
        public List<MessagePacket> VerifyMessagesToMe(string username, string password)
        {
            return null;
        }









    }
}
