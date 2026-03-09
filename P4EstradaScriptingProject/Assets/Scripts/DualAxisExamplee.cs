using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DualAxisExamplee : MonoBehaviour
{
    public Text horizontalValueDisplayText;
    public Text verticalValueDisplayText;
    public float hRange;
    public float vRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float yPos = v * vRange;

        transform.position = new Vector3(xPos, yPos, 0);    
        horizontalValueDisplayText.text = "Horizontal Value: " + h.ToString("F2");
        verticalValueDisplayText.text = "Vertical Value: " + v.ToString("F2");
    }
}
