﻿namespace TransactionService.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string PasswordHash { get; set; }
        public string? Email { get; set; }
    }
}
