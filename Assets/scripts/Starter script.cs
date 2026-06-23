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
        myChoice = true;
        

    }


    void Update()
    {
        if (myNumber == 4 && myChoice == true)
        {
            myName = "Michael";
            //myGate.SetActive(true);
            Name1.GetComponent<TMPro.TMP_Text>().text = "My Number; " + myNumber + " My Name: " + myName;
            Name2.GetComponent<TMPro.TMP_Text>().text = "________________";
        }
        else
        {
            myName = "Matthew";
            //myGate.SetActive(false);
            Name2.GetComponent<TMPro.TMP_Text>().text = "Matthew is active";
            Name1.GetComponent<TMPro.TMP_Text>().text = "Michael is inactive";
        }

        if(myNumber == 0)
        {
            Name1.GetComponent<TMPro.TMP_Text>().text = "";
            Name2.GetComponent<TMPro.TMP_Text>().text = "";
        }
    }

    public void OpenGate()
    {
        myGate.GetComponent<Animator>().Play("Gateswing");
    }
}
