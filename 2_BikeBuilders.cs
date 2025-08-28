/* CSIS2664, 2025
 * Class test 2, Question 4
 * Student number: 2020536070
 * Surname, Initials: Ntshele A
 */

namespace Bikes
{
    abstract class ABikeBuilder : IBikeBuilder
    {
        protected Biketype bikeType = null;

        public ABikeBuilder(string type, Purpose purpose)
        {
            bikeType = new Biketype();
            bikeType.Type = type;
            bikeType.Purpose = purpose;
            SetAttributes();
        } //ctor

        protected abstract void SetAttributes();

        public Biketype GetBiketype()
        {
            return bikeType;
        } //ctor
    } //ABikeBuilder

    class RoadbikeBuilder : ABikeBuilder
    {
        public RoadbikeBuilder() : base("Road bike", Purpose.Tarmac) { }

        protected override void SetAttributes()
        {
            bikeType.Seating = Seating.Aerodynamic;
            bikeType.Handles = Handles.Dropped;
            bikeType.Suspension = Suspension.None;
            bikeType.WheelsTyres = WheelsTyres.Large | WheelsTyres.Narrow | WheelsTyres.Slick;
            bikeType.Gears = Gears.HighRatio;
            bikeType.Accessories = Accessories.Water;
        } //SetAttributes
    } //class RoadBikeBuilder

    class MountainbikeBuilder : ABikeBuilder
    {
        public MountainbikeBuilder() : base("Mountin bike", Purpose.Gravel | Purpose.Offroad) { }

        protected override void SetAttributes()
        {
            bikeType.Suspension = Suspension.Front | Suspension.OptionalBack;
            bikeType.WheelsTyres = WheelsTyres.MediumSize | WheelsTyres.Wide | WheelsTyres.Knobby;
            bikeType.Gears = Gears.WideRange;
            bikeType.Seating = Seating.Neutral;
            bikeType.Handles = Handles.Flat | Handles.Wide;
            bikeType.Accessories = Accessories.Water | Accessories.Pump;
        } //SetAttributes

    } //RoadbikeBuilder

    class CommuterbikeBuilder : ABikeBuilder
    {
        public CommuterbikeBuilder() : base("Commuter bike", Purpose.City) { }

        protected override void SetAttributes()
        {
            bikeType.Suspension = Suspension.OptionalFront;
            bikeType.WheelsTyres = WheelsTyres.MediumSize | WheelsTyres.MediumWidth | WheelsTyres.Grooves;
            bikeType.Gears = Gears.LowRange;
            bikeType.Seating = Seating.Upright;
            bikeType.Handles = Handles.Flat | Handles.Inward;
            bikeType.Accessories = Accessories.Pump;
        } //SetAttributes
    } //CommuterbikeBuilder

    class TouringbikeBuilder : ABikeBuilder
    {
        public TouringbikeBuilder() : base("Touring bike", Purpose.LongDistance) { }

        protected override void SetAttributes()
        {
            bikeType.Suspension = Suspension.OptionalBack;
            bikeType.WheelsTyres = WheelsTyres.MediumSize | WheelsTyres.MediumWidth | WheelsTyres.Grooves;
            bikeType.Gears = Gears.WideRange;
            bikeType.Accessories = Accessories.Water | Accessories.Pump | Accessories.Extras;
            bikeType.Seating = Seating.Neutral;
            bikeType.Handles = Handles.Flat;
        } //SetAttributes
    } //TouringbikeBuilder

} //namespace

    