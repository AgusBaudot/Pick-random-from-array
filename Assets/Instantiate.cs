using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour {

    public GameObject[] array;
    int index = 0;
    int Totalcd = 10;
    float cd = 0f;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
   {
               if (Input.GetKeyDown(KeyCode.Space))
               {
                   for (int i = 0; i <=2; i++)
                   {
                       //if (array[i])
                       //si el obbjecto del array tiene la tag "moneda", spawnealo. Asi se garantiza el drop de moneda.
                   }
                   for (int i = 0; i <= 4; i++)
                   {
                       index = Random.Range(0, array.Length);
                       Instantiate(array[index], transform.position, transform.rotation);
                   }
               }
               for (int i = array.Length - 1; i >= 0; i--)
               {
                   Destroy(array[i].gameObject, 3);
               }

    }
}
