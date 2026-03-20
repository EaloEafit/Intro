using UnityEngine;

public class Operators : MonoBehaviour
{
    public float attackPower = 35.0f;
    public float defensePower = 15.0f;

// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float sum = attackPower + defensePower;
        float difference = attackPower - defensePower;
        float multiply = attackPower * defensePower;
        float quotient = attackPower / defensePower;

        Debug.Log ("Suma de poderes: " + sum);
        Debug.Log ("Diferencia de poderes: " + difference);
        Debug.Log ("Producto de poderes: " + multiply);
        Debug.Log ("Cociente de poderes: " + quotient);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
