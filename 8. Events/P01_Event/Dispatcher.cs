namespace P01_Event
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);

    public class Dispatcher
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                NameChangeEventArgs args = new NameChangeEventArgs(value, name);
                name = value;
                OnNameChange(args);
            }
        }

        public event NameChangeEventHandler NameChange;

        private void OnNameChange(NameChangeEventArgs args)
        {
            //NameChange(this, args);
            NameChange?.Invoke(this, args);
        }
    }
}
