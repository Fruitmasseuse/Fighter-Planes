using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy;
    public GameObject enemyB;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, transform.position, Quaternion.identity);
        InvokeRepeating("CreateEnemy", 1f, 3f);
        InvokeRepeating("CreateEnemyB", 3f, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateEnemy()
    {
        Instantiate(enemy, new Vector3(Random.Range(-9f, 9f), 9f, 0), Quaternion.identity);
    }
    // spawn enemy at y6f to y2.5f
    void CreateEnemyB()
    {
        Instantiate(enemyB, new Vector3(-14f, Random.Range(6f, 2.5f), 0), Quaternion.identity);
    }
}

//Implementing the Life Tracker
using UnityEngine;
using UnityEngine.UI; 

public class PlayerLives : MonoBehaviour
{
    public Text livesText;  // Reference to the UI Text of Lives
    private int lives = 3;  // Starting number of Lives

    void Start()
    {
        UpdateLivesText();  // Initialize the UI text
    }

    public void LoseLife()
    {
        if (lives > 0)
        {
            lives--;  // Decrease lives
            UpdateLivesText();
        }
    }

    public void GainLife()
    {
        lives++;  // Increase lives
        UpdateLivesText();
    }

    private void UpdateLivesText()
    {
        livesText.text = "Lives: " + lives;  // Update the text with current life
    }
}
