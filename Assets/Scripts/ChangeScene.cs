using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void allmenu()
    {
        SceneManager.LoadScene(1);
    }
    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }
    public void hijaiyahscene()
    {
        SceneManager.LoadScene(3);
    }
    public void ARscene()
    {
        SceneManager.LoadScene(2);
    }
}
