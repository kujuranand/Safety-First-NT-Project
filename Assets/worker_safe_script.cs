using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worker_safe_script : MonoBehaviour
{
    public void whenButtonClicked()
    {
        StartCoroutine(anim_delay_2());
        //GetComponent<Animator>().Play("Drunk Running");
    }

    public IEnumerator anim_delay_2()
    {
        Debug.Log(Time.time);
        yield return new WaitForSeconds(4f);
        Debug.Log(Time.time);

        GetComponent<Animator>().Play("Turn_around");
    }
}
