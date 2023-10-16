using UnityEngine;

public class Player : MonoBehaviour, IControllable
{

  public void Run()
    {
        Debug.Log("Player: Run");
    }


   public void Go()
    {
        Debug.Log("Player: go");
    }

    public void Move()
    {
        Run();
    }
}
