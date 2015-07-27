using System;

namespace WindowsFormsApplication1.JsonParser
{
    class JiraChangeLog
    {
        public class Rootobject
        {
            public string expand { get; set; }
            public string id { get; set; }
            public string self { get; set; }
            public string key { get; set; }
            public Fields fields { get; set; }
            public Changelog changelog { get; set; }
        }

        public class Fields
        {
            public Progress progress { get; set; }
            public string summary { get; set; }
            public Timetracking timetracking { get; set; }
            public Issuetype issuetype { get; set; }
            public Votes votes { get; set; }
            public Resolution resolution { get; set; }
            public Fixversion[] fixVersions { get; set; }
            public DateTime resolutiondate { get; set; }
            public object timespent { get; set; }
            public Reporter reporter { get; set; }
            public object aggregatetimeoriginalestimate { get; set; }
            public DateTime created { get; set; }
            public DateTime updated { get; set; }
            public string description { get; set; }
            public Priority priority { get; set; }
            public object duedate { get; set; }
            public object customfield_10001 { get; set; }
            public object[] issuelinks { get; set; }
            public Watches watches { get; set; }
            public Worklog worklog { get; set; }
            public object customfield_10000 { get; set; }
            public object[] subtasks { get; set; }
            public object customfield_10100 { get; set; }
            public Status status { get; set; }
            public object customfield_10006 { get; set; }
            public string[] labels { get; set; }
            public object customfield_10005 { get; set; }
            public int workratio { get; set; }
            public Assignee assignee { get; set; }
            public Attachment[] attachment { get; set; }
            public object customfield_10202 { get; set; }
            public object customfield_10201 { get; set; }
            public object customfield_10501 { get; set; }
            public object aggregatetimeestimate { get; set; }
            public Project project { get; set; }
            public Version[] versions { get; set; }
            public object environment { get; set; }
            public string customfield_10400 { get; set; }
            public object timeestimate { get; set; }
            public DateTime lastViewed { get; set; }
            public Aggregateprogress aggregateprogress { get; set; }
            public Component[] components { get; set; }
            public object customfield_10647 { get; set; }
            public Comment comment { get; set; }
            public object timeoriginalestimate { get; set; }
            public object aggregatetimespent { get; set; }
        }

        public class Progress
        {
            public int progress { get; set; }
            public int total { get; set; }
        }

        public class Timetracking
        {
        }

        public class Issuetype
        {
            public string self { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public string iconUrl { get; set; }
            public string name { get; set; }
            public bool subtask { get; set; }
        }

        public class Votes
        {
            public string self { get; set; }
            public int votes { get; set; }
            public bool hasVoted { get; set; }
        }

        public class Resolution
        {
            public string self { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public string name { get; set; }
        }

        public class Reporter
        {
            public string self { get; set; }
            public string name { get; set; }
            public string emailAddress { get; set; }
            public Avatarurls avatarUrls { get; set; }
            public string displayName { get; set; }
            public bool active { get; set; }
        }

        public class Avatarurls
        {
            public string _16x16 { get; set; }
            public string _24x24 { get; set; }
            public string _32x32 { get; set; }
            public string _48x48 { get; set; }
        }

        public class Priority
        {
            public string self { get; set; }
            public string iconUrl { get; set; }
            public string name { get; set; }
            public string id { get; set; }
        }

        public class Watches
        {
            public string self { get; set; }
            public int watchCount { get; set; }
            public bool isWatching { get; set; }
        }

        public class Worklog
        {
            public int startAt { get; set; }
            public int maxResults { get; set; }
            public int total { get; set; }
            public object[] worklogs { get; set; }
        }

        public class Status
        {
            public string self { get; set; }
            public string description { get; set; }
            public string iconUrl { get; set; }
            public string name { get; set; }
            public string id { get; set; }
        }

        public class Assignee
        {
            public string self { get; set; }
            public string name { get; set; }
            public string emailAddress { get; set; }
            public Avatarurls1 avatarUrls { get; set; }
            public string displayName { get; set; }
            public bool active { get; set; }
        }

        public class Avatarurls1
        {
            public string _16x16 { get; set; }
            public string _24x24 { get; set; }
            public string _32x32 { get; set; }
            public string _48x48 { get; set; }
        }

        public class Project
        {
            public string self { get; set; }
            public string id { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public Avatarurls2 avatarUrls { get; set; }
        }

        public class Avatarurls2
        {
            public string _16x16 { get; set; }
            public string _24x24 { get; set; }
            public string _32x32 { get; set; }
            public string _48x48 { get; set; }
        }

        public class Aggregateprogress
        {
            public int progress { get; set; }
            public int total { get; set; }
        }

        public class Comment
        {
            public int startAt { get; set; }
            public int maxResults { get; set; }
            public int total { get; set; }
            public Comment1[] comments { get; set; }
        }

        public class Comment1
        {
            public string self { get; set; }
            public string id { get; set; }
            public Author author { get; set; }
            public string body { get; set; }
            public Updateauthor updateAuthor { get; set; }
            public DateTime created { get; set; }
            public DateTime updated { get; set; }
        }

        public class Author
        {
            public string self { get; set; }
            public string name { get; set; }
            public string emailAddress { get; set; }
            public Avatarurls3 avatarUrls { get; set; }
            public string displayName { get; set; }
            public bool active { get; set; }
        }

        public class Avatarurls3
        {
            public string _16x16 { get; set; }
            public string _24x24 { get; set; }
            public string _32x32 { get; set; }
            public string _48x48 { get; set; }
        }

        public class Updateauthor
        {
            public string self { get; set; }
            public string name { get; set; }
            public string emailAddress { get; set; }
            public Avatarurls4 avatarUrls { get; set; }
            public string displayName { get; set; }
            public bool active { get; set; }
        }

        public class Avatarurls4
        {
            public string _16x16 { get; set; }
            public string _24x24 { get; set; }
            public string _32x32 { get; set; }
            public string _48x48 { get; set; }
        }

        public class Fixversion
        {
            public string self { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public string name { get; set; }
            public bool archived { get; set; }
            public bool released { get; set; }
            public string releaseDate { get; set; }
        }

        public class Attachment
        {
            public string self { get; set; }
            public string id { get; set; }
            public string filename { get; set; }
            public Author1 author { get; set; }
            public DateTime created { get; set; }
            public int size { get; set; }
            public string mimeType { get; set; }
            public string content { get; set; }
            public string thumbnail { get; set; }
        }

        public class Author1
        {
            public string self { get; set; }
            public string name { get; set; }
            public string emailAddress { get; set; }
            public Avatarurls5 avatarUrls { get; set; }
            public string displayName { get; set; }
            public bool active { get; set; }
        }

        public class Avatarurls5
        {
            public string _16x16 { get; set; }
            public string _24x24 { get; set; }
            public string _32x32 { get; set; }
            public string _48x48 { get; set; }
        }

        public class Version
        {
            public string self { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public string name { get; set; }
            public bool archived { get; set; }
            public bool released { get; set; }
            public string releaseDate { get; set; }
        }

        public class Component
        {
            public string self { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
        }

        public class Changelog
        {
            public int startAt { get; set; }
            public int maxResults { get; set; }
            public int total { get; set; }
            public History[] histories { get; set; }
        }

        public class History
        {
            public string id { get; set; }
            public Author2 author { get; set; }
            public DateTime created { get; set; }
            public Item[] items { get; set; }
        }

        public class Author2
        {
            public string self { get; set; }
            public string name { get; set; }
            public string emailAddress { get; set; }
            public Avatarurls6 avatarUrls { get; set; }
            public string displayName { get; set; }
            public bool active { get; set; }
        }

        public class Avatarurls6
        {
            public string _16x16 { get; set; }
            public string _24x24 { get; set; }
            public string _32x32 { get; set; }
            public string _48x48 { get; set; }
        }

        public class Item
        {
            public string field { get; set; }
            public string fieldtype { get; set; }
            public string from { get; set; }
            public string fromString { get; set; }
            public string to { get; set; }
            public string toString { get; set; }
        }
    }
}


    

