﻿namespace FashionStore.Data
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int IsDeleted { get; set; }
    }
}
