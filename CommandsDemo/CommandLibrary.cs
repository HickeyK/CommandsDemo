using System.Windows.Input;

namespace CommandsDemo
{
    public static class CommandLibrary
    {
        private static RoutedUICommand add = new RoutedUICommand("Add", "Add", typeof(CommandLibrary));

        private static RoutedUICommand remove = new RoutedUICommand("Remove", "Remove", typeof(CommandLibrary));

        //static CommandLibrary()
        //{
        //    add = new RoutedUICommand("Add", "Add", typeof(CommandLibrary));
        //}

        public static RoutedUICommand AddListItem
        {
            get { return add; }
        }

        public static RoutedUICommand RemoveListItem
        {
            get { return remove; }
        }

    }
}
