﻿namespace GraphQL.Database.Entities
{
    public class Book
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool Published { get; set; }

        public string Genre { get; set; }

        public string AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
