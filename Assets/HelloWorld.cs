using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
	public GameObject cubePrefabVar;

    // Start is called before the first frame update
    void Start()
	

    {
        Instantiate (cubePrefabVar);
	print("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate (cubePrefabVar);
    }
}
