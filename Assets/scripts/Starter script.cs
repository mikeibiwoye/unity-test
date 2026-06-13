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
        myNumber = 3;
        myOtherNumber = myNumber;
        

    }


    void Update()
    {
                if (myNumber == 4)
        {
            myName = "Michael";
            myGate.SetActive(true);
        }
        else
        {
            myName = "Matthew";
            myGate.SetActive(false);
        }
    }
}
