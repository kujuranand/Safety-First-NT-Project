using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getting_hit_by_forklift : MonoBehaviour
{

    //public GameObject Male;
    
    // public static CFX_AutoDestructShuriken text;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Animator>().Play("Brooming");
        GetComponent<Animator>().Play("Brooming");
    }

    // Update is called once per frame
    void Update()
    {
        // GetComponent<Animator>().Play("Brooming");
        // if (Animator.IsPlaying("Brooming"))
        //     Broom.SetActive(true);
        // else
        //     Broom.SetActive(false);
    }

    // public void getUp() {
    //     GetComponent<Animator>().Play("stand up");
    // }

    public void whenButtonClicked() {
        
        StartCoroutine(anim_delay());
        
    }

    public IEnumerator anim_delay() {
        Debug.Log(Time.time);
        yield return new WaitForSeconds(3f);
        Debug.Log(Time.time);

        GetComponent<Animator>().Play("Hit_by_Car");
        
        
    }

    // public void onPlay() {
    //     if (Hit_Text.activeInHierarchy == true)
    //         Hit_Text.SetActive(false);
    //     else
    //         Hit_Text.SetActive(true);
    // } 

}
