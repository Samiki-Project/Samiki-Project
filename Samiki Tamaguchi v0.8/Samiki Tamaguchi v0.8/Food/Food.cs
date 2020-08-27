using System;

namespace Samiki_Tamaguchi_v08
{
    public partial class Food
    {
        /// <summary>
        /// Represents the Name of this food
        /// <para> If not defined when instantiating the food class throws an Arguments exception</para>
        /// </summary>
        public string Name_
        {
            get { return Name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException(
                        "Você não inseriu um nome ou inseriu um nome inválido");
                Name = value;
            }
        }

        private string Name;
        /// <summary>
        /// Represents the value that this food recovers from hunger when ingested by Samiki
        /// <para> If not defined when instantiating the food class throws an Arguments exception</para>
        /// </summary>
        public int RecoveryValue_
        {
            get { return RecoveryValue; }
            set
            {
                if (value == default)
                        throw new ArgumentException(
                            "Você não inseriu um valor ou inseriu um valor inválido");
                RecoveryValue = value;
            }
        }

        private int RecoveryValue;
    }
}