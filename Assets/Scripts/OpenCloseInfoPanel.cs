using System.Collections.Generic;
using UnityEngine;

public class OpenCloseInfoPanel : MonoBehaviour
{
    [SerializeField]private List<string> countryList;
    [SerializeField] private bool checkAnim;
    [SerializeField] Animator animator;
    private void Start()
    {
        countryList.Add("0");
        countryList.Add("0");
        countryList.Add("0");
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {               
                //Bas�lan objeyi a listesine ekliyoruz.
                countryList.Add(hit.collider.gameObject.name.ToString());
                /*Burada e�er a listesinde 3 ten �ok obje varsa en �nce ekleneni siliyoruz.
                Bunun amac� bir �ehire 2 kere bas�ld���nda bilgi panelinin kapat�lmas� 3.de ise tekrar a��lmas� i�in  */
                countryList.RemoveAt(countryList.Count - 4);
                //Burada da 2 kere mi 3 kere mi bas�ld� o kontrol ediliyor
                if ((countryList[1] == countryList[2]) && !(countryList[1] == countryList[0]))
                {
                    animator.SetTrigger("Close");
                    checkAnim = false;
                }
                else if ((countryList[1] == countryList[2]) && (countryList[1] == countryList[0]))
                {
                    animator.SetTrigger("Open");
                    checkAnim = true;
                    countryList[1] = "0";
                }
                else if (!checkAnim)
                {
                    animator.SetTrigger("Open");
                    checkAnim = true;
                }
            }
        }
    }
}