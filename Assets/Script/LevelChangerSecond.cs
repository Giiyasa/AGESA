using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangerSecond : MonoBehaviour
{
    public Animator animator;
    public float transitionDelayTime = 1.0f;

    void Awake()
    {
        animator = GameObject.Find("Black fade").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //As an example, we'll be using GetKey() to test out the transition
        //between game scenes, so if you are implementing this with this code
        //make sure to modify the code according to your needs.
        if(Input.GetKey(KeyCode.Space))
        {
            LoadLevel();
        }
    }

    public void LoadLevel()
    {
        StartCoroutine(DelayLoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator DelayLoadLevel(int index)
    {
        animator.SetTrigger("FadeOut");
        yield return new WaitForSeconds(transitionDelayTime);
         SceneManager.LoadScene("2.Second", LoadSceneMode.Additive);
    }
}