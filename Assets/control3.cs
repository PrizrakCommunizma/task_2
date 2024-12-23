using UnityEngine;
using UnityEngine.UI;

public class control3 : MonoBehaviour
{
    private int num;
    public Text textNum;

    private void OnTriggerEnter(Collider other)
    {
        num++;
        textNum.text = num.ToString();
    }
}
