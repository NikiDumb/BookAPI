﻿using Books.Core;
using BooksAPI.Models.Responses;

namespace BooksAPI.Models.Requests;

public class TradeRequestRequest
{
    public Guid BookId { get; set; }

    public Guid BookOfferId { get; set; }

    public Guid OwnerId { get; set; }

    public Guid BuyerId { get; set; }

    public TradeRequestStatus TradeStatus { get; set; }
}
