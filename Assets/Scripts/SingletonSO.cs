using UnityEngine;

public abstract class SingletonSO<T> : ScriptableObject where T : ScriptableObject
{
    static T _instance = null;
    public static T Instance
    {
        get
        {
            if (_instance == null) {
                T[] result = Resources.FindObjectsOfTypeAll<T>();
                if(result.Length == 0)
                {
                    return null;
                }
                if (result.Length >1)
                {
                    return null;
                }
                _instance = result[0];
            }
            return _instance;
        }
    }

}
