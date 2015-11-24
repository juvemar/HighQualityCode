namespace Composite
{
    /// <summary>
    /// The 'ComponentAthlete' abstract class
    /// </summary>
    public abstract class ComponentAthlete
    {
        protected ComponentAthlete(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public abstract void Add(ComponentAthlete athlete);

        public abstract void Remove(ComponentAthlete athlete);

        public abstract void Display(int depth);
    }
}
