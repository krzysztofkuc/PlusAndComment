using System;
using static PlusAndComment.Common.Enums;

namespace PlusAndComment.Common
{
    [Serializable]
    public static class Enums
    {
        //leave it in the same order
        public enum PostType {img, gif, mov};

        public enum UIPostType { humour, picture, link, suchar, article };

        public enum PictureType { img, gif };
    }

    public static class PosTypeExtensions
    {
        public static string ToFriendlyString(this PostType me)
        {
            switch (me)
            {
                case PostType.img:
                    return "img";
                case PostType.gif:
                    return "gif";
                case PostType.mov:
                    return "mov";
                default:
                    return "damn";
            }
        }
    }
}