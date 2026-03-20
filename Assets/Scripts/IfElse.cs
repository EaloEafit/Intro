using UnityEngine;

public class IfElse : MonoBehaviour
{
    public int numberToCheck = 27;    

// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (numberToCheck % 2 == 0)
        {
            Debug.Log ("El numero " + numberToCheck + " es Par");
        }
        else
        {
            Debug.Log ("El numero " + numberToCheck + " es Impar");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
