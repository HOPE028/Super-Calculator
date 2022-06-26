using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class React : MonoBehaviour
{
    private void OnMouseDown() {
        GetComponent<SpriteRenderer>().color = Color.gray;
    }
    private void OnMouseUp() {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
