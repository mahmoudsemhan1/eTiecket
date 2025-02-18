﻿using eTickets.date.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture URL")]
        [Required(ErrorMessage ="profile picture is required")]
        public string ProfilePictureURL { get;set; }
        [Display(Name = "full Name ")]
        [Required(ErrorMessage = "Full Name picture is required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Full Name must be between 3 and 50 chars")]


        public string FullName { get;set;}
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography  is required")]


        public string Bio { get;set;}

        //relation 
        public List<Actor_Movie>? Actor_Movies { get; set; }
    }
}
