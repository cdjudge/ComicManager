namespace ComicManager.Data.Entities
{
    public class Result
    {
        public object aliases { get; set; }
        public string api_detail_url { get; set; }
        public string cover_date { get; set; }
        public string date_added { get; set; }
        public string date_last_updated { get; set; }
        public object deck { get; set; }
        public string description { get; set; }
        public bool has_staff_review { get; set; }
        public int id { get; set; }
        public Image image { get; set; }
        public string issue_number { get; set; }
        public string name { get; set; }
        public string site_detail_url { get; set; }
        public object store_date { get; set; }
        public Volume volume { get; set; }
    }
}