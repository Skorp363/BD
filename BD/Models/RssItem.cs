﻿namespace BD.Models
{
    public class RssItem
    {
        public string Title { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime PubDate { get; set; }
    }
}
