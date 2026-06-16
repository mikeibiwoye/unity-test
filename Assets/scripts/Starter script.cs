using UnityEngine;

public class Starterscript : MonoBehaviour
{
    [SerializeField] int myNumber;
    [SerializeField] string myName;
    [SerializeField] bool myChoice;
    int myOtherNumber;
    [SerializeField] GameObject myGate;
    [SerializeField] GameObject Name1;
    [SerializeField] GameObject Name2;
    
    void Start()
    {
        myNumber = 3;
        myOtherNumber = myNumber;
        

    }


    void Update()
    {
                if (myNumber == 4 && myChoice == true)
        {
            myName = "Michael";
            myGate.SetActive(true);
            Name1.GetComponent<TMPro.TMP_Text>().text = "" + myNumber;
        }
        else
        {
            myName = "Matthew";
            myGate.SetActive(false);
        }
    }
}
