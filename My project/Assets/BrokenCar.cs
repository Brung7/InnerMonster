
using UnityEngine;

public class BrokenCar : CarBase
{

    
    public void Cant()
    {
        Debug.Log("Broken car can't drive" + getSpeed());
        
    }

    public override void Drive()
    {
        Cant();
    }
}
