namespace Simulator
{
    public class Birds : Animals
    {
        private bool canFly = true;
        public bool CanFly { get { return canFly; } init { value = canFly; } }

        public override string Info
        {
            get
            {
                string flying_skill = canFly ? "fly+" : "fly-";
                return $"{Description} ({flying_skill}) <{Size}>";
            }
        }
    }
}