using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenNumbers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int evens = 22; evens <= 100; evens +=2)
	{	
		Debug.Log(evens);
	}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
