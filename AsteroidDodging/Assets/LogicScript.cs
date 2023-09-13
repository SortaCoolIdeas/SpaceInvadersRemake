using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public ShipScript ship;
    public AsteroidSpawnerScript asteroidSpawner;

    public void addScore(int scoreToAdd)
    {
        if (ship.shipIsWorking) 
        {
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void adjustSpawnRate()
    {
        asteroidSpawner.spawnRate = asteroidSpawner.spawnRate - 0.1f;
    }

}
