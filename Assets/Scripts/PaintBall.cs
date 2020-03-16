using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Es.InkPainter;

public class PaintBall : MonoBehaviour
{
    public Brush brush;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        var canvas = col.gameObject.GetComponent<InkCanvas>();
        if (canvas != null)
        {
            canvas.Paint(brush, col.contacts[0].point);
            Destroy(this.gameObject);
        }
    }

}
