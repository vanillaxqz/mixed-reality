using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitCounter : MonoBehaviour
{
    public GameObject GolfClub;
    public GameObject FlagBase;
    public GUIStyle Style;


    //hitCount is the same as the score in golf
    private int hitCount;
    private bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        Style.fontSize = 25;
        hitCount = 0;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        if (!isGameOver)
        {
            GUI.Label(new Rect(50, 50, 200, 200), "Strokes: " + hitCount, Style);
        }
        else
        {
            GUI.Label(new Rect(50, 50, 200, 200), "Game Over! Score: " + hitCount, Style);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == GolfClub)
        {
            hitCount++;
            Debug.Log("Hit!");
        }

        if (collision.gameObject == FlagBase)
        {
            isGameOver = true;
        }
    }
}
