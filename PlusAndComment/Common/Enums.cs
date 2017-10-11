using System;

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
}