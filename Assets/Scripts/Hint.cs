using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
    [SerializeField] GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(HintPop());
    }

    IEnumerator HintPop()
    {
        yield return new WaitForSeconds(10);
        text.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
