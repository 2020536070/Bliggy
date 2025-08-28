/* CSIS2664, 2023
 * Test 1, Question 5
 * P Blignaut 2079034130
 * August 2023
 */

namespace Bikes
{
    interface IBikeBuilder
    {
        Biketype GetBiketype();
        void SetBasics();
        void SetRider();
        void SetAccessories();
    } //IBikeBuilder
} //namespace
