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
    public partial class ShallowUser : StacManType
    {
        [Field("accept_rate")]
        public int? AcceptRate { get; internal set; }

        [Field("display_name")]
        public string DisplayName { get; internal set; }

        [Field("link")]
        public string Link { get; internal set; }

        [Field("profile_image")]
        public string ProfileImage { get; internal set; }

        [Field("reputation")]
        public int? Reputation { get; internal set; }

        [Field("user_id")]
        public int? UserId { get; internal set; }

        [Field("user_type")]
        public Users.UserType UserType { get; internal set; }

    }
}

#pragma warning restore 1591
