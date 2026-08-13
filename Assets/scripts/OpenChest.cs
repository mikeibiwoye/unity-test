using UnityEngine;
using UnityEngine.InputSystem;

public class OpenChest : MonoBehaviour
{
    [SerializeField] bool chestOpen;
    [SerializeField] GameObject chest;

    void Update()
    {
        if (chestOpen == false && Keyboard.current != null && Keyboard.current.eKey.wasPressedThisFrame)
        {
            Open();
        }
    }

    void Open()
    {
        chestOpen = true;
        GameObject targetChest = chest != null ? chest : gameObject;
        Animator animator = targetChest.GetComponent<Animator>();

        if (animator != null)
        {
            animator.Play("OpenChest");
        }
    }
}
