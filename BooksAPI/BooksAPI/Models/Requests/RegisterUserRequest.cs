﻿namespace BooksAPI.Models.Requests;

public class RegisterUserRequest
{
    public string Name { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public bool RememberMe { get; set; }
}
