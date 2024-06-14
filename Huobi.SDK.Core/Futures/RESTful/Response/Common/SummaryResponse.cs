using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.Futures.RESTful.Response.Common
{
    public class SummaryResponse
    {
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public Page page { get; set; }

        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<Component> Components { get; set; }

        [JsonProperty("incidents", NullValueHandling = NullValueHandling.Ignore)]
        public List<Incident> Incidents { get; set; }

        [JsonProperty("scheduled_maintenances", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScheduledMaintenance> ScheduledMaintenances { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Status status { get; set; }
        
        public class Page
        {
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
            public string Url { get; set; }

            [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
            public string TimeZone { get; set; }

            [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
            public string UpdatedAt { get; set; }
        }

        public class Component
        {
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
            public string Status { get; set; }

            [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
            public string CreatedAt { get; set; }

            [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
            public string UpdatedAt { get; set; }

            [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
            public int? Position { get; set; }

            [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
            public object Description { get; set; }

            [JsonProperty("showcase", NullValueHandling = NullValueHandling.Ignore)]
            public bool? Showcase { get; set; }

            [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
            public object GroupId { get; set; }

            [JsonProperty("page_id", NullValueHandling = NullValueHandling.Ignore)]
            public string PageId { get; set; }

            [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
            public bool? Group { get; set; }

            [JsonProperty("only_show_if_degraded", NullValueHandling = NullValueHandling.Ignore)]
            public bool? OnlyShowIfDegraded { get; set; }
        }

        public class Incident
        {
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
            public string Status { get; set; }

            [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
            public string CreatedAt { get; set; }

            [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
            public string UpdatedAt { get; set; }

            [JsonProperty("monitoring_at", NullValueHandling = NullValueHandling.Ignore)]
            public object MonitoringAt { get; set; }

            [JsonProperty("resolved_at", NullValueHandling = NullValueHandling.Ignore)]
            public object ResolvedAt { get; set; }

            [JsonProperty("impact", NullValueHandling = NullValueHandling.Ignore)]
            public string Impact { get; set; }

            [JsonProperty("shortlink", NullValueHandling = NullValueHandling.Ignore)]
            public string Shortlink { get; set; }

            [JsonProperty("started_at", NullValueHandling = NullValueHandling.Ignore)]
            public string StartedAt { get; set; }

            [JsonProperty("page_id", NullValueHandling = NullValueHandling.Ignore)]
            public string PageId { get; set; }

            [JsonProperty("incident_updates", NullValueHandling = NullValueHandling.Ignore)]
            public List<IncidentUpdate> IncidentUpdates { get; set; }

            [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
            public List<Component> Components { get; set; }
        }

        public class IncidentUpdate
        {
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
            public string Status { get; set; }

            [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
            public string Body { get; set; }

            [JsonProperty("incident_id", NullValueHandling = NullValueHandling.Ignore)]
            public string IncidentId { get; set; }

            [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
            public string CreatedAt { get; set; }

            [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
            public string UpdatedAt { get; set; }

            [JsonProperty("display_at", NullValueHandling = NullValueHandling.Ignore)]
            public string DisplayAt { get; set; }

            [JsonProperty("affected_components", NullValueHandling = NullValueHandling.Ignore)]
            public AffectedComponent[] AffectedComponents { get; set; }

            [JsonProperty("deliver_notifications", NullValueHandling = NullValueHandling.Ignore)]
            public bool? DeliverNotifications { get; set; }

            [JsonProperty("custom_tweet", NullValueHandling = NullValueHandling.Ignore)]
            public object CustomTweet { get; set; }

            [JsonProperty("tweet_id", NullValueHandling = NullValueHandling.Ignore)]
            public object TweetId { get; set; }
        }

        public class AffectedComponent
        {
            [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
            public string Code { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("old_status", NullValueHandling = NullValueHandling.Ignore)]
            public string OldStatus { get; set; }

            [JsonProperty("new_status", NullValueHandling = NullValueHandling.Ignore)]
            public string NewStatus { get; set; }
        }

        public class ScheduledMaintenance
        {
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
            public string Status { get; set; }

            [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
            public string CreatedAt { get; set; }

            [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
            public string UpdatedAt { get; set; }

            [JsonProperty("monitoring_at", NullValueHandling = NullValueHandling.Ignore)]
            public object MonitoringAt { get; set; }

            [JsonProperty("resolved_at", NullValueHandling = NullValueHandling.Ignore)]
            public object ResolvedAt { get; set; }

            [JsonProperty("impact", NullValueHandling = NullValueHandling.Ignore)]
            public string Impact { get; set; }

            [JsonProperty("shortlink", NullValueHandling = NullValueHandling.Ignore)]
            public string Shortlink { get; set; }

            [JsonProperty("started_at", NullValueHandling = NullValueHandling.Ignore)]
            public string StartedAt { get; set; }

            [JsonProperty("page_id", NullValueHandling = NullValueHandling.Ignore)]
            public string PageId { get; set; }

            [JsonProperty("incident_updates", NullValueHandling = NullValueHandling.Ignore)]
            public List<IncidentUpdate> IncidentUpdates { get; set; }

            [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
            public List<Component> Components { get; set; }

            [JsonProperty("scheduled_for", NullValueHandling = NullValueHandling.Ignore)]
            public string ScheduledFor { get; set; }

            [JsonProperty("scheduled_until", NullValueHandling = NullValueHandling.Ignore)]
            public string ScheduledUntil { get; set; }
        }

        public class Status
        {
            [JsonProperty("indicator", NullValueHandling = NullValueHandling.Ignore)]
            public string Indicator { get; set; }

            [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
            public string Description { get; set; }
        }
    }
}