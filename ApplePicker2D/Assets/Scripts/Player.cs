using UnityEngine;

public class Player : MonoBehaviour
{
    public string username;
    public int score;
    public int id;
    GameController controller;
    // Constructor
    public Player(string username, int score = 0)
    {
        this.username = username;
        this.score = score;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}
