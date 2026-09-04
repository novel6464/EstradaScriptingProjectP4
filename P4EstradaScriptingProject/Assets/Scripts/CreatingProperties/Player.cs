using UnityEngine;

public class Player : MonoBehaviour
{
    private int experience;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int Expierence
    {
        get
        {
            return experience;
        }
        set
        {  
            experience = value; 
        
        }
    }
    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }
    public int Health { get; set;} 
}
