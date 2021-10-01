using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Credits : MonoBehaviour
{
    public int totalCredits;
    public TextMeshProUGUI creditCounter;

    // Start is called before the first frame update
    void Start()
    {
        creditCounter.text = totalCredits.ToString();
        StartCoroutine(PassiveCredit(100, 1));
    }


    public void Add(int addValue)
    {
        totalCredits += addValue;
        creditCounter.text = totalCredits.ToString();
    }

    public void Subtract(int subValue)
    {
        totalCredits -= subValue;

        if (totalCredits < 0)
        {
            totalCredits = 0;
        }

        creditCounter.text = totalCredits.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            totalCredits = totalCredits + 20000000;
            creditCounter.text = totalCredits.ToString();
        }
    }

    IEnumerator PassiveCredit(int passiveValue, int delay)
    {
        yield return new WaitForSeconds(delay);
        Add(passiveValue);
        StartCoroutine(PassiveCredit(100, 1));
    }
}
