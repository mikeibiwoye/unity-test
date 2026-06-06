using UnityEngine;

public class Starterscript : MonoBehaviour
{
    [SerializeField] int myNumber;
    [SerializeField] string myName;
    [SerializeField] bool myChoice;
    int myOtherNumber;
    [SerializeField] GameObject myGate;

    
    void Start()
    {
        myNumber = 4;
        myName = "jimmy";
        myOtherNumber = myNumber;
        myGate.SetActive(true);
    }

    void Update()
    {
        
    }
}
