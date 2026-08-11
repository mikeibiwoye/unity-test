using UnityEngine;

public class OpenChest : MonoBehaviour
{
    [SerializeField] float internalDistance;
    [SerializeField] bool chestOpen;
    [SerializeField] GameObject chest;

    void Update()
    {
        internalDistance = RayCasting.distanceFromTarget;
        if (chestOpen == false && internalDistance < 2)
        {
            chestOpen = true;
            chest.GetComponent<Animator>().Play("Openchest");
        }
    }


}
