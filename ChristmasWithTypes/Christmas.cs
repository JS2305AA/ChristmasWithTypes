using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int TreeHeight { get; set; } //TODO Make the Height property nullable

        public Day XmasDay { get; set; }
        //TODO Make the property, "Day", type enum
        public enum Day { Mon, Tue, Wed, Thurs, Fri, Sat, Sun };

    }
}
