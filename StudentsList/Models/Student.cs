﻿using System.ComponentModel.DataAnnotations;

namespace StudentsList.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }

        public int GroupId { get; set; }

        public Group Group { get; set; }


    }
}
