using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDoTiro : MonoBehaviour
{
    public float velocTiro = 12.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(Vector3.right * velocTiro * Time.deltaTime); 
        if (transform.position.x > 9.0f) {
        Destroy(this.gameObject);
        }
    }
}
