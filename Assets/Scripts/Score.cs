using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    public int highScore = 0;
    public float timer = 0f;
    public float timerRate = 1f;

    public Text[] scoreDisplays;
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * timerRate;
        if (timer >= 1f)
        {
            score++;
            for (int i = 0; i < scoreDisplays.Length; i++)
            {
                scoreDisplays[i].text = "Score: " + score.ToString();
            }
            timer = 0f;
            if (score > highScore) highScore = score;
        }
    }
}
