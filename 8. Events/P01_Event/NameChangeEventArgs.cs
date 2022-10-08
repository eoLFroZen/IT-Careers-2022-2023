namespace P01_Event
{
    public class NameChangeEventArgs : EventArgs
    {
        public NameChangeEventArgs(string name, string oldName)
        {
            this.OldName = oldName;
            this.Name = name;
        }

        public string Name { get; private set; }
        public string OldName { get; private set; }
    }
}
