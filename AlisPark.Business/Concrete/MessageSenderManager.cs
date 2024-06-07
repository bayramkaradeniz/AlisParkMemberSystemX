using AlisPark.Business.Abstract;
using AlisPark.Entities.Concrete;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlisPark.Business.Concrete
{
    public class MessageSenderManager : IMessageSenderService
    {
        async Task IMessageSenderService.SendMessageAsync(string description, Member member)
        {
            string instanceId = "instance60717";
            string token = "hevcp2bwxty2eje5";
            string mobile = member.MemberPhone;
            string message = description;

            var url = "https://api.ultramsg.com/" + instanceId + "/messages/chat";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Post);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("token", token);
            request.AddParameter("to", mobile);
            request.AddParameter("body", message);


            RestResponse response = await client.ExecuteAsync(request);
            var output = response.Content;
            MessageBox.Show(output);
        }
    }
}
