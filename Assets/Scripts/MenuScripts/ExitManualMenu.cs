using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitManualMenu : MonoBehaviour
{
    [SerializeField] private Button achievementsButton;
    [SerializeField] private Button manualButton;
    [SerializeField] private Button playButton;
    [SerializeField] private Button marketButton;

    public GameObject panel;

    OpenManualMenu manualMenu;
    public void CloseManualMenu()
    {
        achievementsButton.gameObject.SetActive(true);
        manualButton.gameObject.SetActive(true);
        playButton.gameObject.SetActive(true);
        marketButton.gameObject.SetActive(true);
        manualMenu = GetComponent<OpenManualMenu>();
        panel.SetActive(false);
        manualMenu.mMenuAnimator.SetTrigger("CloseManual");
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
