using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class secondscene : MonoBehaviour
{
    [SerializeField]private int a; 
    public void hahha()
    {
        SceneManager.LoadScene(a);
    }
}
