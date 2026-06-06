using UnityEngine;

public class Starterscript : MonoBehaviour
{
    [serializeField] int myNumber;
    [serializeField] string myName;
    [serializeField] bool myChoice;
    int myOtherNumber;
    [serializeField] GameObject myGate;

    
    void Start()
    {
        myNumber = 4;
        myName = "jimmy";
        myOtherNumber = myNumber;
        myGate.setActive(true);
    }

    void Update()
    {
        
    }
}
