using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
  //  [SerializeField] Text _currentScoreTextView;

   // public static int _currentCoin;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            ReloadLevel();
        }
    }

    void ReloadLevel()
    {
        int activeSceneIndex =
            SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(activeSceneIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
        //Just to make sure its working
    }

    //  public void IncreaseCoin(int coinIncrease)
    // {
    // increase coin
    //     _currentCoin += coinIncrease;
    // update coin display, so we can see the new coin count
    //      _currentCoinTextView.text = "Coin: " + _currentCoin.ToString();
    //  }
}
