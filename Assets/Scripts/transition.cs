using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transition : MonoBehaviour
{

    private Animator transitionAnim;

     void Start()
    {

        transitionAnim = GetComponent<Animator>();
    }

    public void LoadScene(string scene) {


        StartCoroutine(Transition(scene));

    }
    IEnumerator Transition(string scene)

    {
        transitionAnim.SetTrigger("Exittolevel");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(scene);
    }


}
