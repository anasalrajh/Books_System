using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Books_System.Models
{

   
    public class StackResponse
    {
        [JsonProperty("items")]
        public List<items> items { get; set; }
      
        public Nullable<bool> has_more { get; set; }
        [JsonProperty("quota_max")]
        public Nullable<int> quota_max { get; set; }
        [JsonProperty("quota_remaining")]
        public Nullable<int> quota_remaining { get; set; }
    }
 
        public class items
    {
        [JsonProperty("tags")]
        public IEnumerable<string> tags { get; set; }
       
        [JsonProperty("is_answered")]
        public Nullable<bool> is_answered { get; set; }
        [JsonProperty("view_count")]
        public Nullable<int> view_count { get; set; }
        [JsonProperty("answer_count")]
        public Nullable<int> answer_count { get; set; }
        
            [JsonProperty("creation_date")]
        public string creation_date { get; set; }
        [JsonProperty("score")]
        public Nullable<int> score { get; set; }
       
        [JsonProperty("question_id")]

        public Nullable<int> question_id { get; set; }
        [JsonProperty("content_license")]
        public string content_license { get; set; }
        [JsonProperty("link")]
        public string link { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
      
    }
    public class owner
    {
       
     
        [JsonProperty("reputation")]
        public Nullable<int> reputation { get; set; }
        [JsonProperty("user_id")]
        public Nullable<int> user_id { get; set; }
        [JsonProperty("user_type")]
        public string user_type { get; set; }
        [JsonProperty("accept_rate")]
        public Nullable<int> accept_rate { get; set; }
        [JsonProperty("profile_image")]
        public string profile_image { get; set; }
        [JsonProperty("display_name")]
        public string display_name { get; set; }
        [JsonProperty("link")]
        public string link { get; set; }

    }
}