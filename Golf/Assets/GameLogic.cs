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
    private MeshRenderer meshRenderer;
    private Color originalColor;

    // Start is called before the first frame update
    void Start()
    {
        Style.fontSize = 25;
        hitCount = 0;
        isGameOver = false;
        meshRenderer = GetComponent<MeshRenderer>();
        originalColor = meshRenderer.material.color;

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
            meshRenderer.material.color = Color.yellow;
        }

        if (collision.gameObject == FlagBase)
        {
            isGameOver = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == GolfClub)
        {
            meshRenderer.material.color = originalColor;
        }
    }
}
