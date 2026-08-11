using UnityEngine;

public class GemCollect : MonoBehaviour
{
    [SerializeField] AudioSource ding;

    void Awake()
    {
        if (ding == null)
        {
            GameObject dingObject = GameObject.Find("Ding");
            if (dingObject != null)
            {
                ding = dingObject.GetComponent<AudioSource>();
            }
        }
    }


    void OnTriggerEnter(Collider other)
    {
    if (ding != null)
        {
             ding.Play();
        }

        Destroy(gameObject);
    }
}
