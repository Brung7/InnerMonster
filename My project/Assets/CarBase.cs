
using UnityEngine;

public abstract class CarBase : MonoBehaviour, IControllable
{
    private float speed = 10.0f;

    public float getSpeed() {
        
        return speed; 
                 
    }
  
    public virtual void Drive()
    {
        Debug.Log("Car is driving");
    }


    public void Move()
    {
        Drive();
    }
}
