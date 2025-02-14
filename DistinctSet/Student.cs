﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctSet
{
    internal class Student:IEquatable<Student>
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Equals(Student? other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (object.ReferenceEquals(other, this))
            {
                return true;
            }
            return Id.Equals(other.Id) && Name.Equals(other.Name);
        }
        public override int GetHashCode()
        {
            int idHashCode = Id.GetHashCode();
            int nameHashCode = Name.GetHashCode();

            return idHashCode ^ nameHashCode;
        }
    }
}
