using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitPlayMenu : MonoBehaviour
{
    [SerializeField] private Button achievementsButton;
    [SerializeField] private Button manualButton;
    [SerializeField] private Button playButton;
    [SerializeField] private Button marketButton;
    public GameObject panel;
    OpenPlayMenu playMenu;
    public void ClosePlayMenu()
    {
        achievementsButton.gameObject.SetActive(true);
        manualButton.gameObject.SetActive(true);
        playButton.gameObject.SetActive(true);
        marketButton.gameObject.SetActive(true);
        playMenu = GetComponent<OpenPlayMenu>();
        panel.SetActive(false);
        playMenu.pMenuAnimator.SetTrigger("ClosePlay");
        StartCoroutine(LockButtons());
    }
    public IEnumerator LockButtons() 
    {
        achievementsButton.interactable = false;
        manualButton.interactable = false;
        playButton.interactable = false;
        marketButton.interactable = false;
        yield return new WaitForSeconds(0.8f);
        achievementsButton.interactable = true;
        manualButton.interactable = true;
        playButton.interactable = true;
        marketButton.interactable = true;
    }
}