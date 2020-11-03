using UnityEngine;
using UnityEngine.SceneManagement;

public class mainpagemanger : MonoBehaviour
{
    
    public void gamestard()
        {
        print("new game");
        SceneManager.LoadScene("關卡1");

        }
  public void endgame()
        {
        print("end game");
        Application.Quit();
        }

}
