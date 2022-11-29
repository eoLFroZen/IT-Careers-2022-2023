namespace Demo
{
    public delegate void ContentChangedEventHandler(string content);

    public class Publisher
    {
        private string content;

        public event ContentChangedEventHandler ContentChanged;

        public string Content
        {
            get { return content; }
            set
            {
                content = value;
                OnContentChanged();
            }
        }

        protected void OnContentChanged()
        {
            ContentChanged(content);
        }
    }
}
