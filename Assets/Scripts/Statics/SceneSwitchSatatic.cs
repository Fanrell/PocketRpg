public static class SceneSwitchStatic
{
    private static int _sceneToSwitch = 2;
    
    public static int SceneToSwitch
    {
        get => _sceneToSwitch;
        set
        {
            _sceneToSwitch = value;
        }
    }
}
