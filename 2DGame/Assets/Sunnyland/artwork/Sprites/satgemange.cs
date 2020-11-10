using UnityEngine;
using UnityEngine.SceneManagement;

public class satgemange : MonoBehaviour
{
    public void Nextlevel(string namelv)
    {
        SceneManager.LoadScene(namelv);
    }
    public void Backtomeun()
    {
        SceneManager.LoadScene("mainpage");
    }
    public void Quit()
    {
        Application.Quit();
    }















}