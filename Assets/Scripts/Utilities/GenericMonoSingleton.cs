using ServiceLocator.Wave;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericMonoSingleton<T> : MonoBehaviour where T : GenericMonoSingleton<T>
{
    // Start is called before the first frame update
    public static T Instance { get { return instance; } }
    private static T instance;

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance =(T) this;
        }
        else
        {
            Destroy(instance);
            Debug.Log("Destroyed Second Instance of "+(T)this+" Service");
        }
    }
}
