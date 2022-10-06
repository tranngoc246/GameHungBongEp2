using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public float spawnTime;
    float m_spawnTime;

    int m_score;
    bool m_isGameOver;

    UIManager m_ui;
    Line m_line;

    int m_speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        m_spawnTime = 0;
        m_ui = FindObjectOfType<UIManager>();
        m_line = FindObjectOfType<Line>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_isGameOver)
        {
            m_ui.ShowReplayPanel(true);
            m_line.moveSpeed = 0;
            return;
        }

        if(m_score - m_speed == 5)
        {
            m_line.moveSpeed += 10;
            m_speed += 5;
        }

        m_spawnTime -= Time.deltaTime;
        if (m_spawnTime <= 0)
        {
            SpawnBall();
            m_spawnTime = spawnTime;
        }
    }

    void SpawnBall()
    {
        if (ball)
        {
            Instantiate(ball, new Vector2(Random.Range(-11, 11), 6), Quaternion.identity);
        }
    }

    public void Replay()
    {
        m_ui.ShowReplayPanel(false);
        m_score = 0;
        m_isGameOver = false;
        m_ui.SetScoreText("Score: " + m_score);
        m_line.moveSpeed = 40;
    }

    public int GetScore()
    {
        return m_score;
    }
    public void SetScore(int value)
    {
        m_score = value;
    }
    public void IncremenScore()
    {
        m_score++;
        m_ui.SetScoreText("Score: " + m_score);
    }
    public bool IsGameOver()
    {
        return m_isGameOver;
    }
    public void SetGameOverState(bool state)
    {
        m_isGameOver = state;
    }
}
