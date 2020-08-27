using System;

namespace Samiki_Tamaguchi_v08
{
    public partial class Samiki
    {
        private DateTime BirthDate;

        /// <summary>
        /// When executed it creates a timestamp for generation of age property values,
        /// Based on the <see cref="BirthDate"/> property that is
        /// generated when creating the Samiki instance
        /// </summary>
        public void GettingOld()
        {
            TimeSpan Timestamp = DateTime.Now - BirthDate;
            SamikiAge = Convert.ToInt32(Timestamp.TotalMinutes);
            //Console.WriteLine($"{Age} minutos de idade");
        }
    }
}
