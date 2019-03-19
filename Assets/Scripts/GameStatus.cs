using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{

    //config parameters
    [Range(0.1f, 10f)][SerializeField] float gameSpeed = 1f;
    [SerializeField] int scorePerBlockDestroyed = 10;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] bool isAutoplayEnabled;

    //state variables
    [SerializeField] int currentScore = 0;


    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if(gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        } else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        scoreText = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += scorePerBlockDestroyed;
        scoreText.text = currentScore.ToString();
    }

    public bool IsAutoplayEnabled()
    {
        return isAutoplayEnabled;
    }
}
