using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeTimer : MonoBehaviour 
{
    float coffeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        // If the coffee's temperature is greater thant the hottest drinking temperaure...
        if (coffeTemperature > hotLimitTemperature)
        {
            //... do this.
            print("Coffe is too hot.");
        }
        // If the coffee's temperature is greater than the hottest drinking temperature...
        else if (coffeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("Coffee is too cold,");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("Coffee is just right.");
        }
    }
}