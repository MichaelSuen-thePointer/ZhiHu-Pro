﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

using Newtonsoft.Json;

using Zhihu.Common.Helper;
using Zhihu.Common.Model;
using Zhihu.Common.Model.Result;


namespace Zhihu.Common.Net
{
    public sealed class NotifyApi
    {
        internal async Task<NotifiesResult> CheckFollowsAsync(String access, String request, Boolean autoCache = false)
        {
            var http = new HttpUtility();

            var response = await http.GetAsync(Utility.Instance.BaseUri, request, access, autoCache);

            if (false == String.IsNullOrEmpty(response.Json))
            {
                var json = response.Json;

                var obj = JsonConvert.DeserializeObject<Notifies>(json);

                return new NotifiesResult(obj);
            }
            else
            {
                var json = response.Error;

                return new NotifiesResult(new Exception(json));
            }
        }

        internal async Task<NotifiesResult> GetContentsAsync(String access, String request, Boolean autoCache = false)
        {
            var http = new HttpUtility();

            var response = await http.GetAsync(Utility.Instance.BaseUri, request, access, autoCache);

            if (false == String.IsNullOrEmpty(response.Json))
            {
                var json = response.Json;

                var obj = JsonConvert.DeserializeObject<Notifies>(json);

                return new NotifiesResult(obj);
            }
            else
            {
                var json = response.Error;

                return new NotifiesResult(new Exception(json));
            }
        }

        internal async Task<NotifiesResult> GetLikesAync(String access, String request, Boolean autoCache = false)
        {
            var http = new HttpUtility();

            var response = await http.GetAsync(Utility.Instance.BaseUri, request, access, autoCache);

            if (false == String.IsNullOrEmpty(response.Json))
            {
                var json = response.Json;

                var obj = JsonConvert.DeserializeObject<Notifies>(json);

                return new NotifiesResult(obj);
            }
            else
            {
                var json = response.Error;

                return new NotifiesResult(new Exception(json));
            }
        }

        internal async Task<OperationResult> HasReadContentsAsync(String access)
        {
            var http = new HttpUtility();

            var body = new StringContent("action=read_all");
            body.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            var response = await http.PutAsync(Utility.Instance.BaseUri, "notifications/contents", access, body);

            if (false == String.IsNullOrEmpty(response.Json))
            {
                var json = response.Json;

                var obj = JsonConvert.DeserializeObject<Operation>(json);

                return new OperationResult(obj);
            }
            else
            {
                var json = response.Error;

                return new OperationResult(new Exception(json));
            }
        }

        internal async Task<OperationResult> HasReadFollowsAsync(String access)
        {
            var http = new HttpUtility();

            var body = new StringContent("action=read_all");
            body.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            var response = await http.PutAsync(Utility.Instance.BaseUri, "notifications/unread_follows", access, body);

            if (false == String.IsNullOrEmpty(response.Json))
            {
                var json = response.Json;

                var obj = JsonConvert.DeserializeObject<Operation>(json);

                return new OperationResult(obj);
            }
            else
            {
                var json = response.Error;

                return new OperationResult(new Exception(json));
            }
        }

        internal async Task<NotifyItemResult> HasReadContentAsync(String access, String contentId)
        {
            var http = new HttpUtility();

            var body = new StringContent("");
            body.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            var response = await http.PutAsync(Utility.Instance.BaseUri, String.Format("notifications/{0}", contentId), access, body);

            if (false == String.IsNullOrEmpty(response.Json))
            {
                var json = response.Json;

                var obj = JsonConvert.DeserializeObject<NotifyItem>(json);

                return new NotifyItemResult(obj);
            }
            else
            {
                var json = response.Error;

                return new NotifyItemResult(new Exception(json));
            }
        }
    }
}
