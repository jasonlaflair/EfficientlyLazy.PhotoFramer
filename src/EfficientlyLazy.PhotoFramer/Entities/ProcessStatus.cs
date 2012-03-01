namespace EfficientlyLazy.PhotoFramer.Entities
{
    internal class ProcessStatus
    {
        public int Added { get; private set; }
        public int Existing { get; private set; }
        public int Removed { get; private set; }

        public void PhotoAdded()
        {
            Added++;
        }

        public void PhotoExists()
        {
            Existing++;
        }

        public void PhotoRemoved()
        {
            Removed++;
        }

        public void PhotoRemoved(int removed)
        {
            Removed += removed;
        }
    }
}
