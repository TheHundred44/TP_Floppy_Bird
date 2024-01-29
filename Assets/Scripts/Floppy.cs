using UnityEngine;

public class Floppy : MonoBehaviour
{
    private static Floppy _instance;

    public static Floppy Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("Floppy");
                _instance= go.AddComponent<Floppy>();
            }

            return _instance;
        }
    }

    public FloppyJump FloppyJump { get; private set; }

    public InterfaceManager InterfaceManager;

    private FloppyAnimation _animator;

    private void Awake()
    {
        FloppyJump = this.GetComponent<FloppyJump>();
        _animator = GetComponent<FloppyAnimation>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (InterfaceManager.LoseInterface.activeSelf)
            {
                InterfaceManager.SceneRestart();
            }
            else
            {
                FloppyJump.Jump();
            }
        }
    }
}
