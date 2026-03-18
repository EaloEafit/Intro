using UnityEngine;

public class VariablesExamples : MonoBehaviour
{
    // Al declarar las variables como "public" podemos verlas y modificarlas
    public string characterName = "Omega";
    public int healthPoints = 100;
    public float moveSpeed = 5.5f;
    public bool hasDungeonKey = false;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("--- Ficha del Personaje ---");
        Debug.Log("Nombre: " + characterName);
        Debug.Log("Puntos de Vida: " + healthPoints);
        Debug.Log("Velocidad de Movimiento: " + moveSpeed);
        Debug.Log("¿Tiene la llave?: " + hasDungeonKey);

    }

    // Update is called once per frame
    void Update()
    {
        
    }






}
