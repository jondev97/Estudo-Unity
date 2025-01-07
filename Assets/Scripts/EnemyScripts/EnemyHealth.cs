using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    private int health = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   


    public int Health{
        get {return health;}
        set {health = value;}
    }

}
