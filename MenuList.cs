

namespace Multifabriken
{
    public class MenuList
    {
        public string Name { get; set; }

        public List<Menu> Items = new List<Menu>();

        public MenuList(string name)
        {
            Name = name;
        }
    }
}
