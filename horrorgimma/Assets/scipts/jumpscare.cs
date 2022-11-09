using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpscare : MonoBehaviour
{
    public GameObject jumpscaretrigger;
    public GameObject camera;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(tijd());
            StartCoroutine(audio());
        }
    }

    public IEnumerator tijd()
    {
        jumpscaretrigger.gameObject.SetActive(true);


        yield return new WaitForSeconds(1);

        jumpscaretrigger.gameObject.SetActive(false);
     
    }

    public IEnumerator audio()
    {
        camera.GetComponent<AudioSource>().enabled = true;

        yield return new WaitForSeconds(5);

        camera.GetComponent<AudioSource>().enabled = false;

    }

}
