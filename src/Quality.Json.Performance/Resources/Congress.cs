namespace Quality.Json.Performance.Resources
{
    public class CongressContainer
    {
        public Action[] actions { get; set; }
        public Amendment[] amendments { get; set; }
        public Committee[] committees { get; set; }
        public Cosponsor[] cosponsors { get; set; }
        public Bill[] related_bills { get; set; }
        public Title[] titles { get; set; }

        public History history { get; set; }
        public Sponsor sponsor { get; set; }
        public Summary summary { get; set; }

        public string bill_id { get; set; }
        public string bill_type { get; set; }
        public bool by_request { get; set; }
        public string congress { get; set; }
        public string introduced_at { get; set; }
        public string number { get; set; }
        public string official_title { get; set; }
        public string popular_title { get; set; }
        public string short_title { get; set; }
        public string status { get; set; }
        public string status_at { get; set; }
        public string[] subjects { get; set; }
        public string subjects_top_term { get; set; }
        public string updated_at { get; set; }

        public class Action
        {
            public string acted_at { get; set; }
            public string[] committees { get; set; }
            public Reference[] references { get; set; }
            public string status { get; set; }
            public string text { get; set; }
            public string type { get; set; }
            public string[] bill_ids { get; set; }
            public string result { get; set; }
            public string roll { get; set; }
            public string vote_type { get; set; }
            public string how { get; set; }
            public string where { get; set; }
        }

        public class Reference
        {
            public string reference { get; set; }
            public string type { get; set; }
        }

        public class Amendment
        {
            public string amendment_id { get; set; }
            public string amendment_type { get; set; }
            public string chamber { get; set; }
            public string number { get; set; }
        }

        public class Committee
        {
            public string[] activity { get; set; }
            public string committee { get; set; }
            public string committee_id { get; set; }
            public string subcommittee { get; set; }
            public string subcommittee_id { get; set; }
        }

        public class Cosponsor
        {
            public string district { get; set; }
            public string name { get; set; }
            public string sponsored_at { get; set; }
            public string state { get; set; }
            public string thomas_id { get; set; }
            public string title { get; set; }
            public string withdrawn_at { get; set; }
        }

        public class History
        {
            public bool active { get; set; }
            public string active_at { get; set; }
            public bool awaiting_signature { get; set; }
            public bool enacted { get; set; }
            public string house_passage_result { get; set; }
            public string house_passage_result_at { get; set; }
            public bool vetoed { get; set; }
        }

        public class Bill
        {
            public string bill_id { get; set; }
            public string reason { get; set; }
            public string type { get; set; }
        }

        public class Sponsor
        {
            public string district { get; set; }
            public string name { get; set; }
            public string state { get; set; }
            public string thomas_id { get; set; }
            public string title { get; set; }
            public string type { get; set; }
        }

        public class Summary
        {
            public string @as { get; set; }
            public string date { get; set; }
            public string text { get; set; }
        }

        public class Title
        {
            public string @as { get; set; }
            public bool is_for_portion { get; set; }
            public string title { get; set; }
            public string type { get; set; }
        }
    }
}