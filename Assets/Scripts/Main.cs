using TMPro;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_txt;

    private void Awake()
    {
        m_txt.text = "Tuanjie Main!";
    }
}