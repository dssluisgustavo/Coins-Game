using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField] Score scoreClass;
    [SerializeField] GameObject finishedScreen;
    int points;

    private void Start()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else { Destroy(gameObject); }

        points = GameObject.FindObjectsOfType<CoinPickup>().Length;
        scoreClass.RefreshUI(points);
    }
    public void ReduceCoin()
    {
        points--;
        scoreClass.RefreshUI(points);
        if(points == 0)
        {
            finishedScreen.SetActive(true);
        }
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }
}
