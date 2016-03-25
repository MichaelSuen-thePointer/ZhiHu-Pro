﻿
using System.Linq;

using Newtonsoft.Json;


// ReSharper disable once CheckNamespace
namespace Zhihu.Common.Model
{
    public sealed class CollectionAnswers : IPaging
    {
        [JsonProperty("paging")]
        public Paging Paging { get; set; }

        [JsonProperty("data")]
        public Answer[] Items { get; set; }

        public object[] GetItems()
        {
            return Items.ToArray();
        }
    }
}
