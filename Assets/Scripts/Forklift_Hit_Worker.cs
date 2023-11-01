using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forklift_Hit_Worker : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(anim_delay());

        if (other.gameObject.CompareTag("Forklift"))
        {
            GetComponent<Animator>().Play("Hit_by_Car");
            GetComponent<AudioSource>().Play();
        }
    }

    public IEnumerator anim_delay()
    {
        Debug.Log(Time.time);
        yield return new WaitForSeconds(15f);
        Debug.Log(Time.time);

        GetComponent<Animator>().Play("Get_up_backwards");
    }
    
    

}
