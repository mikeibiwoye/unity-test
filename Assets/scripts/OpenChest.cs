using UnityEngine;

public class OpenChest : MonoBehaviour
{
    [SerializeField] float internalDistance;
    [SerializeField] bool chestOpen;
    [SerializeField] GameObject chest;
    [SerializeField] float openDistance = 2f;

    void Update()
    {
        internalDistance = RayCasting.distanceFromTarget;
        if (chestOpen == false && internalDistance > 0 && internalDistance < openDistance)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                chestOpen = true;
                GameObject targetChest = chest != null ? chest : gameObject;
                targetChest.GetComponent<Animator>().Play("OpenChest");
            }
        }
    }


}
