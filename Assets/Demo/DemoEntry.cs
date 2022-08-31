using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Puerts;

public class DemoEntry : MonoBehaviour
{

    private JsEnv _jsEnv1;
    private JsEnv _jsEnv2;
    
    public GameObject testPrefab;

    // Start is called before the first frame update
    async void Start()
    {
        _jsEnv1 = new JsEnv(new DefaultLoader(), -1);
        _jsEnv1.ExecuteModule("index");
        await Task.Delay(1000);
        _jsEnv2 = new JsEnv(new DefaultLoader(), -1);
        _jsEnv2.ExecuteModule("index");
    }

    private void Update() {
        if (_jsEnv1 != null){
            _jsEnv1.Tick();
        }
        if (_jsEnv2 != null){
            _jsEnv2.Tick();
        }
    }
}
