using UnityEngine;
using UnityEngine.UI;

public class OpenManualMenu : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private Button achievementsButton;
    [SerializeField] private Button manualButton;
    [SerializeField] private Button playButton;
    [SerializeField] private Button marketButton;


    public Animator mMenuAnimator;
    private void Start()
    {
        mMenuAnimator = GetComponent<Animator>();
    }
    public void OpenAnimation()
    {
        playButton.gameObject.SetActive(false);
        manualButton.gameObject.SetActive(false);
        marketButton.gameObject.SetActive(false);
        achievementsButton.gameObject.SetActive(false);
        panel.SetActive(true);
        mMenuAnimator.SetTrigger("OpenManual");        
    }
}
