using UnityEngine;
using UnityEngine.UI;

public class OpenPlayMenu : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private Button achievementsButton;
    [SerializeField] private Button manualButton;
    [SerializeField] private Button playButton;
    [SerializeField] private Button marketButton;

    public Animator pMenuAnimator;
    private void Start()
    {
        pMenuAnimator = GetComponent<Animator>();
    }
    public void OpenAnimation()
    {
        playButton.gameObject.SetActive(false);
        manualButton.gameObject.SetActive(false);
        marketButton.gameObject.SetActive(false);
        achievementsButton.gameObject.SetActive(false);
        panel.SetActive(true);
        pMenuAnimator.SetTrigger("OpenPlay");
    }
}