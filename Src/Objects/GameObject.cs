namespace Snake.Src.Objects
{
    public abstract class GameObject
    {
        public abstract void Render(Graphics graphics);
        public abstract void Update(float deltatime);
    }
}