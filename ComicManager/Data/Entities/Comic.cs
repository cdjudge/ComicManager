namespace ComicManager.Data.Entities
{
    public class Comic
    {
        public int id { get; set; }
        public string issue_number { get; set; }
        public string volume_name { get; set; }
        public string name { get; set; }
        public string cover_date { get; set; }
        public string date_added { get; set; }
        public string date_last_updated { get; set; }
        public string description { get; set; }
        public string date_aquired { get; set; }
        public string price_paid { get; set; }
        public string thumb_nail_url { get; set; }

    }
}