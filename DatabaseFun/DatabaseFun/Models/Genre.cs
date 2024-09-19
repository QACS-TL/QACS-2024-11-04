using System;
using System.Collections.Generic;

namespace DatabaseFun.Models;

public partial class Genre
{
    public int GenreId { get; set; }

    public string? GenreName { get; set; }

    public virtual ICollection<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();
}
