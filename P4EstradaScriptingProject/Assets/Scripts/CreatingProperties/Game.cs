using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player mPLayer = new Player();
        mPLayer.Expierence = 5;
        int x = mPLayer.Expierence;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
