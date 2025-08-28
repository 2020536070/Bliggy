/* CSIS2664, 2025
 * Class test 2, Question 4
 * Student number:2020536070
 * Surname, Initials: NTSHELE A
 */


using System;

namespace Bikes
{
    [Flags] enum Purpose { Tarmac = 1, Gravel=2, Offroad=4, City=8, LongDistance=16 }
    [Flags] enum WheelsTyres { Large=1, Narrow=2, Wide=4, Knobby=8, MediumWidth=16, MediumSize=32, Slick=64, Grooves=128 }
    [Flags] enum Suspension { None=1, Front=2, Back=4, OptionalFront=8, OptionalBack=16 }
    [Flags] enum Gears { HighRatio=1, WideRange=2, LowRange=4 }
    [Flags] enum Seating { Aerodynamic=1, Neutral=2, Upright=4 }
    [Flags] enum Handles { Dropped=1, Flat=2, Wide=4, Inward=8 }
    [Flags] enum Accessories { Water=1, Pump=2, Extras=4 }

    class Biketype
    {
        //Properties
        public string Type { get; set; }
        public Purpose Purpose { get; set; }
        public WheelsTyres WheelsTyres { get; set; }
        public Suspension Suspension { get; set; }
        public Gears Gears { get; set; }
        public Seating Seating { get; set; }
        public Handles Handles { get; set; }
        public Accessories Accessories { get; set; }

        //ToString
        public override string ToString()
        {
            return "Type           : " + Type + "\r\n"
                 + "Purpose        : " + Purpose.ToString() + "\r\n"
                 + "Wheels & Tyres : " + WheelsTyres.ToString() + "\r\n"
                 + "Suspension     : " + Suspension.ToString() + "\r\n"
                 + "Gears          : " + Gears.ToString() + "\r\n"
                 + "Seating        : " + Seating.ToString() + "\r\n"
                 + "Handles        : " + Handles.ToString() + "\r\n"
                 + "Accessories    : " + Accessories.ToString() + "\r\n";
        } //ToString
    } //class BikeType
} //namespace
