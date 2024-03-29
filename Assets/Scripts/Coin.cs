using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float yAngle;
    public GameObject objekti;
    public PointCounter script;
    public AudioSource coinSound;


    // Start is called before the first frame update
    void Start()
    {
        script = objekti.GetComponent<PointCounter>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0,yAngle,0,Space.Self);
    }
    private void OnTriggerEnter(Collider other){
        if(other.tag=="Player"){
            script.points = script.points + 1;
            coinSound.Play();
            Destroy(gameObject);
            Debug.Log(other.tag);
        }
    }
}
