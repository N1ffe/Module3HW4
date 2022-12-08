namespace Module3HW4_linq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IContactCollection<string, PhoneRecord> contactCollection = new ContactCollection(new System.Globalization.CultureInfo("en-US"));

            // where, select, orderby, count
            var data1 = contactCollection.Where(c => c.Value.Name.ToLower().StartsWith('e')).Select(x => x.Value.Name).OrderBy(x => x);
            Console.WriteLine($"Found records: {data1.Count()}");
            foreach (string contactName in data1)
            {
                Console.WriteLine(contactName);
            }
            Console.WriteLine();

            // skip, take, firstordefault
            var data2 = contactCollection.Skip(5).Take(5).FirstOrDefault(c => c.Value.Phone.EndsWith('3'));
            Console.WriteLine($"{data2.Value.Name.PadRight(15)} {data2.Value.Phone}\n");

            // all, any
            Console.WriteLine($"All contact names are longer than 5: {contactCollection.All(c => c.Value.Name.Length > 5)}");
            Console.WriteLine($"There is contact that ends with with j: {contactCollection.Any(c => c.Value.Name.ToLower().EndsWith('j'))}");
        }
    }
}