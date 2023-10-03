using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int a = 30;
    public int b = 20;
    public int c;
    // Start is called before the first frame update
    void Start()
    {
        c = a + b;
        Debug.Log(c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
