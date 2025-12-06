using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class ButtonScript : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{ 
    private Animator animator;
    public GameObject button;
     private bool isHover = true;

    void Start()
    {
        animator = GetComponent<Animator>();
        isHover = true;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isHover = true;
        animator.SetBool("isHover", isHover);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
      isHover = false;
        animator.SetBool("isHover", false);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }
}
