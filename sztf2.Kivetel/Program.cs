namespace sztf2.Kivetel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Storage str = new Storage(3, 3);
                str.AddItem("alma");
                str.AddItem("körte");
                str.AddItem("barack");
                str.AddItem("főtt denevért");
                str.AddItem("banán");
                str.AddItem("trabant");
                str.AddItem("adófizetők");
                str.AddItem("főtt denevért");
                str.AddItem("banán");
                str.AddItem("trabant");

                string foundItem = str.GetItem("barack");
            }
            catch (NoItemFoundException exp)
            {
                Console.WriteLine(exp.Message);
            }
            catch (StorageFullException exp)
            {
                Console.WriteLine(exp.Message);
            }
            Console.WriteLine("Ez már a hibakezelés utáni rész");
        }
    }
}
