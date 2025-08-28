/* CSIS2664, 2023
 * Test 1, Question 5
 * P Blignaut
 * August 2023
 */

namespace Bikes
{
    class Director
    {
        public void BuildBike(IBikeBuilder bikeBuilder)
        {
            bikeBuilder.SetBasics();
            bikeBuilder.SetRider();
            bikeBuilder.SetAccessories();
        } //BuildBike

    } //class Director
}
