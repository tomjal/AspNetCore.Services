// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ConsumingWebsite.Clients.DataService.Models
{
    using ConsumingWebsite.Clients;
    using ConsumingWebsite.Clients.DataService;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class BlogPostModel
    {
        /// <summary>
        /// Initializes a new instance of the BlogPostModel class.
        /// </summary>
        public BlogPostModel()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlogPostModel class.
        /// </summary>
        public BlogPostModel(string id = default(string), string title = default(string), string content = default(string), string author = default(string), System.DateTime? published = default(System.DateTime?), System.DateTime? modified = default(System.DateTime?), IList<string> tags = default(IList<string>))
        {
            Id = id;
            Title = title;
            Content = content;
            Author = author;
            Published = published;
            Modified = modified;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "published")]
        public System.DateTime? Published { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modified")]
        public System.DateTime? Modified { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }

    }
}
