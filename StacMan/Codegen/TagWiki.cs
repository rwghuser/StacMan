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
    public partial class TagWiki : StacManType
    {
        [Field("body")]
        public string Body { get; internal set; }

        [Field("body_last_edit_date")]
        public DateTime? BodyLastEditDate { get; internal set; }

        [Field("excerpt")]
        public string Excerpt { get; internal set; }

        [Field("excerpt_last_edit_date")]
        public DateTime? ExcerptLastEditDate { get; internal set; }

        [Field("last_body_editor")]
        public ShallowUser LastBodyEditor { get; internal set; }

        [Field("last_excerpt_editor")]
        public ShallowUser LastExcerptEditor { get; internal set; }

        [Field("tag_name")]
        public string TagName { get; internal set; }

    }
}

#pragma warning restore 1591
