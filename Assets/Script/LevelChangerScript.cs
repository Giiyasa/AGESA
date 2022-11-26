using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangerScript : MonoBehaviour
{
  
  public Animator animator;
  private int levelToLoad;

    void Update() {
        if (Input.GetMouseButtonDown(0))
      {
        FadeToLevel(1);
      }  
        
    }
    public void FadeToLevel (int levelIndex) 
    {
        animator.SetTrigger ("FadeOut");

    }

    public void  OnFadeComplete ()
    {
       SceneManager.LoadScene("3.Home", LoadSceneMode.Additive);
    }
}
