using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEntreEscenas : MonoBehaviour
{
    private void Awake()
    {

        var noDestriurEntreEscenas = FindObjectsOfType<LogicaEntreEscenas>();
        if (noDestriurEntreEscenas.Length > 1)
    {

  Destroy(gameObject);
  return;

    }

    DontDestroyOnLoad(gameObject);

}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
