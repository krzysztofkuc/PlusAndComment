﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static PlusAndComment.Common.Enums;

namespace PlusAndComment.Models
{
    public class MainPostVM
    {
        public int? ID { get; set; }
        public string Header { get; set; }
        public string FilePath { get; set; }
        public string ApplicationUser_Id { get; set; }
        public ApplicationUser User { get; set; }
        public Nullable<int> PostEntity_ID { get; set; }
        public int PlusAmount { get; set; }
        public int MinusAmount { get; set; }
        public string ShortDescription { get; set; }

        [DisplayFormat(NullDisplayText="")]
        [Required(ErrorMessage = "Pole opis nie może być puste.")]
        public string LongDescription { get; set; }
        public string ReferenceUrl { get; set; }
        public string Url { get; set; }
        public string EmbedUrl { get; set; }
        public bool Removed { get; set; }
        public PostType postType { get; set; }
        [Display(Name ="18+")]
        public bool NeedAge { get; set; }
        public bool Banned { get; set; }
        [Display(Name = "Data Rejestracji")]
        public DateTime RegisterDate { get; set; }
        public DateTime? BannEndDate { get; set; }
        public ICollection<ApplicationUser> UsersVotesOnThisPost;
        public ICollection<MainPostVM> Posts { get; set; }

        private int amountOfAllComments = 0;
        private bool AmountOofCOmmentsCounted = false;

        public int AmountOfAllcommens { get
            { if (!AmountOofCOmmentsCounted)
                    this.GetAmountOfAllComments(Posts);
                AmountOofCOmmentsCounted = true;
                return this.amountOfAllComments;
            }}

        private void GetAmountOfAllComments(ICollection<MainPostVM> posts)
        {
            SetAmountOfAllComments(posts);
        }

        private int SetAmountOfAllComments(ICollection<MainPostVM> posts)
        {
            if (posts == null)
                return 0;

            foreach (var item in posts)
            {
                this.amountOfAllComments++;

                if (item.Posts.Count > 0)
                    SetAmountOfAllComments(item.Posts);
            }
            return 0;
        }
    }
}