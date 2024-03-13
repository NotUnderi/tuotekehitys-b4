using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointCounter : MonoBehaviour
{

    public float points;
    public TextMeshProUGUI point;
    public TextMeshProUGUI finalpoints;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string point_s = string.Format("{0}", points);
        point.text = point_s;
        finalpoints.text = point_s;
    }
}
