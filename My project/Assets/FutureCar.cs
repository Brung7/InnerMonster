
using UnityEngine;

public class FutureCar : CarBase
{
    public void Fly()
    {
        Debug.Log("Feature Car is flying,"+ "Speed: " + getSpeed());
    }

   public override void Drive()
    {
       Fly();
    }
}
