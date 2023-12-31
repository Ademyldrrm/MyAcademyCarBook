﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
    }
}
