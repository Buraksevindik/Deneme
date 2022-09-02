using UnityEngine;
using UnityEngine.UI;

public class OpenAchievementsMenu : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private Button playButton;
    [SerializeField] private Button manualButton;
    [SerializeField] private Button marketButton;
    [SerializeField] private Button achievementsButton;

    public Animator aMenuAnimator;
    private void Start()
    {
        aMenuAnimator = GetComponent<Animator>();
    }
    public void OpenAnimation()
    {
        playButton.gameObject.SetActive(false) ;
        manualButton.gameObject.SetActive(false);
        marketButton.gameObject.SetActive(false);
        achievementsButton.gameObject.SetActive(false);
        panel.SetActive(true);
        aMenuAnimator.SetTrigger("OpenAchievements");
    }
}