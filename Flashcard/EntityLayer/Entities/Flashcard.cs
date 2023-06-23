using System;
using System.Collections.Generic;

namespace EntityLayer.Entities;

public partial class Flashcard
{
    public int FlashcardId { get; set; }

    public string? Question { get; set; }

    public string? Answer { get; set; }
}
