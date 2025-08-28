/* CSIS2664, 2023
 * Test 1, Question 5
 * P Blignaut 2079034130
 * August 2023
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
            //Remove SetAttributes
        } //ctor

        public abstract void SetBasics(); //Suspension, Wheels & Tyres, Gears
        public abstract void SetRider();  //Seating, Handles
        public abstract void SetAccessories();

        public Biketype GetBiketype()
        {
            return bikeType;
        } //ctor
    } //ABikeBuilder

    class RoadBikeBuilder : ABikeBuilder
    {
        public RoadBikeBuilder() : base("Road bike", Purpose.Tarmac) { }

        public override void SetBasics()
        {
            bikeType.Suspension = Suspension.None;
            bikeType.WheelsTyres = WheelsTyres.Large | WheelsTyres.Narrow | WheelsTyres.Slick;
            bikeType.Gears = Gears.HighRatio;
        }

        public override void SetRider()
        {
            bikeType.Seating = Seating.Aerodynamic;
            bikeType.Handles = Handles.Dropped;
        }

        public override void SetAccessories()
        {
            bikeType.Accessories = Accessories.Water;
        } //SetAccessories

    } //class RoadBikeBuilder

    class MountainbikeBuilder : ABikeBuilder
    {
        public MountainbikeBuilder() : base("Mountin bike", Purpose.Gravel | Purpose.Offroad) { }

        public override void SetBasics()
        {
            bikeType.Suspension = Suspension.Front | Suspension.OptionalBack;
            bikeType.WheelsTyres = WheelsTyres.MediumSize | WheelsTyres.Wide | WheelsTyres.Knobby;
            bikeType.Gears = Gears.WideRange;
        }

        public override void SetRider()
        {
            bikeType.Seating = Seating.Neutral;
            bikeType.Handles = Handles.Flat | Handles.Wide;
        }

        public override void SetAccessories()
        {
            bikeType.Accessories = Accessories.Water | Accessories.Pump;
        } //SetAccessories
    } //MountainbikeBuilder

    class CommuterbikeBuilder : ABikeBuilder
    {
        public CommuterbikeBuilder() : base("Commuter bike", Purpose.City) { }

        public override void SetBasics()
        {
            bikeType.Suspension = Suspension.OptionalFront;
            bikeType.WheelsTyres = WheelsTyres.MediumSize | WheelsTyres.MediumWidth | WheelsTyres.Grooves;
            bikeType.Gears = Gears.LowRange;
        }

        public override void SetRider()
        {
            bikeType.Seating = Seating.Upright;
            bikeType.Handles = Handles.Flat | Handles.Inward;
        }

        public override void SetAccessories()
        {
            bikeType.Accessories = Accessories.Pump;
        } //SetAccessories
    } //CommuterbikeBuilder

    class TouringbikeBuilder : ABikeBuilder
    {
        public TouringbikeBuilder() : base("Touring bike", Purpose.LongDistance) { }

        public override void SetBasics()
        {
            bikeType.Suspension = Suspension.OptionalBack;
            bikeType.WheelsTyres = WheelsTyres.MediumSize | WheelsTyres.MediumWidth | WheelsTyres.Grooves;
            bikeType.Gears = Gears.WideRange;
        }

        public override void SetRider()
        {
            bikeType.Seating = Seating.Neutral;
            bikeType.Handles = Handles.Flat;
        }

        public override void SetAccessories()
        {
            bikeType.Accessories = Accessories.Water | Accessories.Pump | Accessories.Extras;
        } //SetAccessories
    } //TouringbikeBuilder

} //namespace

    