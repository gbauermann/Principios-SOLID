using System;

namespace Interface_Segregation_Principle
{
    public interface ILibraryItem
    {
        string LibraryId { get; set; }
        string Title { get; set; }        

    }
}