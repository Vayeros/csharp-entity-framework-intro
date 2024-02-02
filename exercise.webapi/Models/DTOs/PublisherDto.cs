﻿namespace exercise.webapi.Models.DTOs
{
    public class PublisherDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookDto> Books { get; set; }
    }
}
