using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    // Static instance of the singleton
    private static T _instance;

    // Property to access the instance
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                // If no instance exists, find or create the singleton object
                _instance = FindObjectOfType<T>();

                if (_instance == null)
                {
                    // If still no instance found, create a new GameObject and add the script
                    GameObject singletonObject = new GameObject(typeof(T).Name);
                    _instance = singletonObject.AddComponent<T>();
                }
            }

            return _instance;
        }
    }

    // Optional: Add your singleton-specific code here

    private void Awake()
    {
        // Ensure there's only one instance of the singleton
        if (_instance == null)
        {
            _instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Optional: Add your other methods and properties here
}
