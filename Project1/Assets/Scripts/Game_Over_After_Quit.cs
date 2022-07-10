using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Over_After_Quit : MonoBehaviour
{
    public void OnClick_ReturnGameButton()
    {
        SceneManager.LoadScene(2);
    }

}
