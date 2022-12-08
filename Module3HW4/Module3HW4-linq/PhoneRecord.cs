namespace Module3HW4_linq
{
    public class PhoneRecord : IComparable<PhoneRecord>
    {
        public PhoneRecord(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int CompareTo(PhoneRecord? other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
