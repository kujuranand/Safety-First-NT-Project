using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forklift_anim1 : MonoBehaviour
{
    
    //public GameObject Male;
    
    // public static CFX_AutoDestructShuriken text;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Animator>().Play("Brooming");
        //GetComponent<Animator>().Play("Talking_on_Phone");
        //audio = GetComponent<AudioSource>();
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
        GetComponent<Animator>().Play("Forklift_reverse_turn 1", -1, 0f);
        
        GetComponent<AudioSource>().Play();
        //StartCoroutine(anim_delay());
        
    }

    // public void whenButtonClickedAgain() {
    //     GetComponent<Animator>().Play("Forklift_reverse_turn 1");
        
    //     GetComponent<AudioSource>().Play();

    // }

    // public IEnumerator anim_delay() {
    //     Debug.Log(Time.time);
    //     yield return new WaitForSeconds(0f);
    //     Debug.Log(Time.time);

    //     GetComponent<Animator>().Play("truck_animation");
    //     GetComponent<AudioSource>().Play();
        
    // }

    // public void onPlay() {
    //     if (Hit_Text.activeInHierarchy == true)
    //         Hit_Text.SetActive(false);
    //     else
    //         Hit_Text.SetActive(true);
    // } 

}
