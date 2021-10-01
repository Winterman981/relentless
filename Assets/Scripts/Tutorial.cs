using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] GameObject text1;
    [SerializeField] GameObject text2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TextPop());
    }

    IEnumerator TextPop()
    {
        yield return new WaitForSeconds(9);
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(true);
        yield return new WaitForSeconds(7);
        text2.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
