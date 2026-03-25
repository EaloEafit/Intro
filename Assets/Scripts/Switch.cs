using UnityEngine;

public class Switch : MonoBehaviour
{
    public int ClassSelection = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string className;

        switch (ClassSelection)
        {
            case 1:
                className = "Warrior";
                break;
            case 2:
                className = "Wizzard";
                break;
            case 3:
                className = "Archer";
                break;
            default: 
                className = "Invalid class";
                break;
        }

        Debug.Log ("You selected the class: " + className);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
