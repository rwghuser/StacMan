// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

using System;

namespace StackExchange.StacMan
{
    public partial class User : StacManType
    {
        [Field("about_me")]
        public string AboutMe { get; internal set; }

        [Field("accept_rate")]
        public int? AcceptRate { get; internal set; }

        [Field("account_id")]
        public int AccountId { get; internal set; }

        [Field("age")]
        public int? Age { get; internal set; }

        [Field("answer_count")]
        public int AnswerCount { get; internal set; }

        [Field("badge_counts")]
        public BadgeCount BadgeCounts { get; internal set; }

        [Field("creation_date")]
        public DateTime CreationDate { get; internal set; }

        [Field("display_name")]
        public string DisplayName { get; internal set; }

        [Field("down_vote_count")]
        public int DownVoteCount { get; internal set; }

        [Field("is_employee")]
        public bool IsEmployee { get; internal set; }

        [Field("last_access_date")]
        public DateTime LastAccessDate { get; internal set; }

        [Field("last_modified_date")]
        public DateTime? LastModifiedDate { get; internal set; }

        [Field("link")]
        public string Link { get; internal set; }

        [Field("location")]
        public string Location { get; internal set; }

        [Field("profile_image")]
        public string ProfileImage { get; internal set; }

        [Field("question_count")]
        public int QuestionCount { get; internal set; }

        [Field("reputation")]
        public int Reputation { get; internal set; }

        [Field("reputation_change_day")]
        public int ReputationChangeDay { get; internal set; }

        [Field("reputation_change_month")]
        public int ReputationChangeMonth { get; internal set; }

        [Field("reputation_change_quarter")]
        public int ReputationChangeQuarter { get; internal set; }

        [Field("reputation_change_week")]
        public int ReputationChangeWeek { get; internal set; }

        [Field("reputation_change_year")]
        public int ReputationChangeYear { get; internal set; }

        [Field("timed_penalty_date")]
        public DateTime? TimedPenaltyDate { get; internal set; }

        [Field("up_vote_count")]
        public int UpVoteCount { get; internal set; }

        [Field("user_id")]
        public int UserId { get; internal set; }

        [Field("user_type")]
        public Users.UserType UserType { get; internal set; }

        [Field("view_count")]
        public int ViewCount { get; internal set; }

        [Field("website_url")]
        public string WebsiteUrl { get; internal set; }

    }
}

#pragma warning restore 1591
