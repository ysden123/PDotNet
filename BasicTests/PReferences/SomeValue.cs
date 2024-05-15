
namespace StulSoft.BasicTests.PReferences
{
    public class SomeValue : IEquatable<SomeValue?>
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public SomeValue(int age, string name) {
            Age = age;
            Name = name;
        }

        public override string ToString()
        {
            return $"SomeValue: Age={Age}, Name={Name}";
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SomeValue);
        }

        public bool Equals(SomeValue? other)
        {
            return other is not null &&
                   Age == other.Age &&
                   Name == other.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Age, Name);
        }

        public static bool operator ==(SomeValue? left, SomeValue? right)
        {
            return EqualityComparer<SomeValue>.Default.Equals(left, right);
        }

        public static bool operator !=(SomeValue? left, SomeValue? right)
        {
            return !(left == right);
        }
    }
}
