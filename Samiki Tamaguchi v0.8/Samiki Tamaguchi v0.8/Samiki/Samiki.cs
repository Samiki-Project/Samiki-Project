using System;

namespace Samiki_Tamaguchi_v08
{
    public partial class Samiki
    {
        /// <summary>
        /// Default Constructor for Samiki
        /// </summary>
        public Samiki() 
        {
            Name_ = default;
            BirthDate = DateTime.Now; 
        }

        /// <summary>
        /// Property that saves Samiki's Name
        /// <para>By default it's "Samiki Kobayashi" but can be customized</para>
        /// </summary>
        private string Name { get; set; }

        /// <summary>
        /// Support Fields to Set and Get Samiki's Name depending the circumstance
        /// </summary>
        public string Name_
        {
            get { return Name; }
            set
            {
                if (string.IsNullOrEmpty(value)) Name = "Samiki Kobayashi";
                else { Name = value; }
            }
        }

        /// <summary>
        /// Property to obtain the age of Samiki from the Samiki Class
        /// <para>
        /// <c>Warn: ReadOnly</c>
        /// </para>
        /// <para> Gets the Samiki's age from <see cref="SamikiAge"/> attribute</para>
        /// </summary>
        public int Age { get { return SamikiAge; } }

        /// <summary>
        /// Property to define internally the age of Samiki
        /// <para><c>The Age is Defined by the number of minutes the program is running</c></para>
        /// </summary>
        private int SamikiAge { get; set; }
    }
}
