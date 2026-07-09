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
    [SerializeField] GameObject firstButton;


    [SerializeField] GameObject fadeIn;
    [SerializeField] GameObject fadeOut;
    [SerializeField] GameObject hiddenSphere;




    void Start()
    {
        myNumber = 3;
        myChoice = true;
        StartCoroutine(MySequence());

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
    }

    public void OpenGate()
    {
        myGate.GetComponent<Animator>().Play("Gate swing");
    }

    public void HideButton()
    {
        firstButton.SetActive(false);
    }

    IEnumerator MySequence()
    {
        yield return new WaitForSeconds(0.5f);
        fadeIn.SetActive(true);
        myGate.GetComponent<Animator>().Play("Gate swing");
        yield return new WaitForSeconds(4f);
        firstButton.SetActive(false);
        yield return new WaitForSeconds(2f);
        hiddenSphere.SetActive(true);
        yield return new WaitForSeconds(2f);
        fadeOut.SetActive(true);
    }
}