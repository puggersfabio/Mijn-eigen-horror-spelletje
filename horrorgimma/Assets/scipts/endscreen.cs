using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endscreen : MonoBehaviour
{
    public GameObject endscrn;
    [SerializeField] float walkspeed = 2.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            endscrn.gameObject.SetActive(true);
            
        }
    }


}
