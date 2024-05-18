using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class App : MonoBehaviour
{
    private AsyncOperationHandle<GameObject> opHandle;

    [SerializeField] private TextMeshProUGUI m_txt;

    private void Awake()
    {
        m_txt.text = "Hello Tuanjie!";

        var key = "Res/Main.prefab";
        opHandle = Addressables.LoadAssetAsync<GameObject>(key);
        opHandle.Completed += (op) =>
        {
            if (opHandle.Status == AsyncOperationStatus.Succeeded)
            {
                var obj = opHandle.Result;
                Instantiate(obj, transform);
            }
        };
    }

    private void OnDestroy()
    {
        Addressables.Release(opHandle);
    }
}