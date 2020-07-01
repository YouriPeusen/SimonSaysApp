using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimonSaysApp.Model
{
	class Light
	{
		public int LightId { get; set; }

		public void SetLightOn()
		{
			HttpWebRequest request = WebRequest.Create("http://127.0.0.1:8080/json.htm?type=command&param=switchlight&idx="+LightId.ToString()+"&switchcmd=On") as HttpWebRequest;
			HttpWebResponse response = request.GetResponse() as HttpWebResponse;
			Stream stream = response.GetResponseStream();
			StreamReader reader = new StreamReader(stream);
		}

		public void SetLightOff()
		{
			HttpWebRequest request = WebRequest.Create("http://127.0.0.1:8080/json.htm?type=command&param=switchlight&idx=" + LightId.ToString() + "&switchcmd=Off") as HttpWebRequest;
			HttpWebResponse response = request.GetResponse() as HttpWebResponse;
			Stream stream = response.GetResponseStream();
			StreamReader reader = new StreamReader(stream);
		}
	}
}
