﻿using System.Security.Cryptography.X509Certificates;

namespace MagicVilla_VillaAPI.Models.Dto
{
    public class LoginResponseDTO
    {
        public LocalUser User { get; set; }
        public string Token { get; set; }
    }
}
