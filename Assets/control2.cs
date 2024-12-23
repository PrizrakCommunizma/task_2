using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control2 : MonoBehaviour
{
    public int x;
    public int y;
    public int z;
    public void OnCollisionEnter(Collision collision)
    {
        x = Random.Range(0, 255);
        y = Random.Range(0, 255);
        z = Random.Range(0, 255);
        this.GetComponent<Renderer>().material.color = new Color32((byte)x, (byte)y, (byte)z, 1);
    }

}
