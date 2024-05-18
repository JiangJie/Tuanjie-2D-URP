using TMPro;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_txt;

    private void Awake()
    {
        Debug.Log("Main Awake");

        m_txt.text = "Tuanjie Main!";
    }
}