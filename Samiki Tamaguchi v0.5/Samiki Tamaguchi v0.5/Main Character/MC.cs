namespace Samiki_Tamaguchi
{
    public partial class MC
    {
        /// <summary>
        /// Main Character's Name
        /// <para></para>
        /// By default it is "Akira Mizushima", but can be customized.
        /// </summary>
        public string Name { get; set; } = "Akira Mizushima";

        /// <summary>
        /// Main Character's Money
        /// <para></para>
        /// By default it is 500 Yen, but it can be set or Randomized.
        /// </summary>
        public float Money { get; set; } = 500;

        public MC(bool random = false)
        {
            if (random) GetRandomValues();
        }

    }
}