﻿namespace WebApi.Database.Entities
{
    public class User
    {
        public uint Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
