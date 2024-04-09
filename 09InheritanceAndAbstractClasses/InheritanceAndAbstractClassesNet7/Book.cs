using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstractClasses
{
    public class Book
    {
        
        public string Title { get; set; }
        public string Author { get; set; }
        public long ISBN { get; set; }

        public override bool Equals(object? obj)
        { 
            // If this and obj do not refer to the same type, then they are not equal.
            if (obj.GetType() != this.GetType()) return false;
            // Return true if Title and Author fields match.
            var other = (Book)obj;
            return (this.Title == other.Title) && (this.Author == other.Author);
        }

        public override int GetHashCode()
        {
            string hashString = ISBN.ToString()[..9]; //get first 9 digits
            return int.Parse(hashString);
        }
        public override string ToString()
        {
            return $"Title={Title}, Author={Author}";
        }
    }
}
