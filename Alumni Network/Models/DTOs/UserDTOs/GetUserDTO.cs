﻿using System.ComponentModel.DataAnnotations;

namespace Alumni_Network.Models.DTOs.User
{
    public class GetUserDTO
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [Url]
        public string? PictureUrl { get; set; }

        [MaxLength(250)]
        public string? Status { get; set; }

        [MaxLength(500)]
        public string? Bio { get; set; }

        [MaxLength(250)]
        public string? FunFact { get; set; }
    }
}
