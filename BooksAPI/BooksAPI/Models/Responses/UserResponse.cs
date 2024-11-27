﻿namespace BooksAPI.Models.Responses;

public class UserResponse
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public int Trades { get; set; }
}
