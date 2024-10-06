using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputeDistance : MonoBehaviour
{
    public GameObject Cactus1;
    public GameObject Cactus2;
    public float Distance;

    public GUIStyle Style;

    // Start is called before the first frame update
    void Start()
    {
        Style.fontSize = 50;
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(Cactus1.transform.position, Cactus2.transform.position);   
    }

    // Called for rendering GUI
    void OnGUI()
    {
        GUI.Label(new Rect(50, 150, 200, 200), "Value: " + Distance, Style);
    }
}
