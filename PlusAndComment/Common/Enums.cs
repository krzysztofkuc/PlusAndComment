using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.Serialization;

namespace PlusAndComment.Common
{
    [Serializable]
    public static class Enums
    {
        //leave it in the same order
        public enum PostType {img, gif, mov, suchar, article};
    }
}